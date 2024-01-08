using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace CoreAndFood.Controllers
{
    public class CategoryController : Controller
    {
        //Tüm fonksiyonlarda kullanabilmek adına globale taşıdık.
        CategoryRepository categoryRepository = new CategoryRepository();
        Context c = new Context();

        public IActionResult Index(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(categoryRepository.List(x=>x.CategoryName==p));
            }
            //classımızdan nesne türettik ve bu classın kalıtımla aldığı metodu viewe parametre olarak gönderdik.    
            return View(categoryRepository.TList());
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            //Validationdan geçemezsen CategoryAdd sayfasını tekrar gönder.
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            categoryRepository.TAdd(p);
            return RedirectToAction("Index");
        }

        //Update sayfası
        public IActionResult CategoryGet(int id) {
            var x = categoryRepository.TGet(id);
            Category ct = new Category()
            {
                CategoryName=x.CategoryName,
                CategoryDescription = x.CategoryDescription,
                CategoryId= x.CategoryId
                
            };
            return View(ct);
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category p)
        {
            //Nesenenin id değerine uyan neseyi x'de tuttuk.
            var x = categoryRepository.TGet(p.CategoryId);
            //Eski değerler x'de. Yeni değerler p'de.
            //Eski değerler yerine yeni değerleri atıyoruz.
            x.CategoryName = p.CategoryName;
            x.CategoryDescription = p.CategoryDescription;
            x.Status = true;

            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryDelete(int id)
        {
            var x = categoryRepository.TGet(id);
            x.Status = false;
            //Verileri veri tabanında değiştirelim.
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
