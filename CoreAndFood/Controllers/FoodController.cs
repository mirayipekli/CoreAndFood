using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository foodRepository = new FoodRepository();

        Context c = new Context();

        public IActionResult Index(int page = 1)
        {
            //Sayfalama işlemi 1. sayfadan başlasın. 
            //Her sayfada 3 ürün olsun.
            return View(foodRepository.TList("Category").ToPagedList(page, 3));
        }



        [HttpGet]
        public IActionResult FoodAdd()
        {
            //Sayfa yüklendiğinde görünecek veriler olduğundan dolayı get metodumuza yazdık. 
            //Kategorilerdeki her bir kategoriyi liste şeklinde x içine attı.
            //Listenin her bir elemanı için kategori adını text kısmına, yani dropdownda görünecek yazılar olarak ayarladı.
            //Value kısmını da arkaplanda, veritabanında id olarak tuttu.
            //Sonrasında tüm bunlardan gelen sonuçları listeye çevirdi.
            //Tüm bu listeyi viewbag ile viewe taşıdı.
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                           
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }

        [HttpPost]
        public IActionResult FoodAdd(Food p)
        {
            foodRepository.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult FoodDelete(int id)
        {
            //Food nesnesi oluşturduk. Foodidsi gelen id ile eşit olanı sil dedik.s
            foodRepository.TDelete(new Food {FoodId=id });
            return RedirectToAction("Index");
        }

        //Update sayfası
        public IActionResult FoodGet(int id)
        {
            var x = foodRepository.TGet(id);
            List<SelectListItem> values = (from y in c.Categories.ToList()
                                           select new SelectListItem
                                           {

                                               Text = y.CategoryName,
                                               Value = y.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            //bir nesne oluştur. Bu nesnenin her bir alanına idsi verilen alanları ata.
            Food f = new Food()
            {
                FoodId=x.FoodId,
                CategoryId = x.CategoryId,
                FoodName = x.FoodName,
                FoodPrice = x.FoodPrice,
                FoodStock = x.FoodStock,
                FoodDescription = x.FoodDescription,
                FoodImageUrl = x.FoodImageUrl
            };
            return View(f);
        }

        [HttpPost]
        public IActionResult FoodUpdate(Food p)
        {
            var x = foodRepository.TGet(p.FoodId);
            x.FoodId = p.FoodId;
            x.FoodName = p.FoodName;
            x.FoodPrice = p.FoodPrice;
            x.FoodStock = p.FoodStock;
            x.FoodImageUrl = p.FoodImageUrl;
            x.FoodDescription = p.FoodDescription;
            x.CategoryId = p.CategoryId;

            foodRepository.TUpdate(x);

            return RedirectToAction("Index");
        }

    }
}
