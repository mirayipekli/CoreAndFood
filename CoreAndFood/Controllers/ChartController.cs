using CoreAndFood.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data;
using CoreAndFood.Data.Models;

namespace CoreAndFood.Controllers
{
    public class ChartController : Controller
    {
        //Pie Chart
        public IActionResult Index()
        {
            return View();
        }

        //Column Chart
        public IActionResult Index2()
        {
            return View();
        }


        //Pie & Column Chart List
        //Class2 den nesneler türetiyorum
        public IActionResult VisualizeProductResult()
        {
            return Json(ProList());
        }

        public List<Class1> ProList()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                proName = "Computer",
                proStock = 150
            });

            cs.Add(new Class1()
            {
                proName = "Lcd",
                proStock = 75
            });

            cs.Add(new Class1()
            {
                proName = "Usb Disk",
                proStock = 220
            });

            return cs;
        }



        //***************************************************************


        //Dynamic Chat
        public IActionResult Index3()
        {
            return View();
        }

        //Veirabanından listeyi alıp json formatında döndürür.
        public IActionResult VisualizeProductResult2()
        {
            return Json(FoodList());
        }


        //Verilerimi veri tabanından çekiyor
        public List<Class2> FoodList()
        {
            //Class2 türünde bir liste şeklinde nesne oluşturduk.
            List<Class2> cs2 = new List<Class2>();
            //Veritabanımdan bir nesne oluşturduk.
            using (var c = new Context())
            {
                //Foods tablasunda her bir öge için dönüş yapmak için select kullandık.
                //Veritabanımdaki her bir özelliği c2 deki özelliğe atadık.
                //Listeye çevirip döndürdük.
                cs2 = c.Foods.Select(x => new Class2
                {
                    foodName = x.FoodName,
                    foodStock = x.FoodStock
                }).ToList();
            }
            return cs2;
        }


        public IActionResult Statistics()
        {
            Context c = new Context();

            //Total Food
            var deger1 = c.Foods.Count();
            ViewBag.d1 = deger1;

            //Total Category
            var deger2 = c.Categories.Count();
            ViewBag.d2 = deger2;

            //Total Fruit
            //İd değerini bizim vermememiz gerekiyor. Meyvenin Idsini bulup onu kullanmalı.
            //Adı fruit olan kategorinin idsini seç. Yiyecek idsinin meyve idsi olan 1 ile eşleşenlerini tut.
            var frid = c.Categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryId).FirstOrDefault();
            var deger3 = c.Foods.Where(x => x.CategoryId==frid).Count();
            ViewBag.d3 = deger3;

            //Total Vegetable
            //Az önce olduğu gibi idyi biz vermeden bulsun istiyoruz. Ayrıca bir değişkene atamadan da yapabiliriz.
            //Adı vegetable olan kategorinin idsini seç. Yiyecek idsi sebze idsi ile eşleşenleri tut. Say
            var deger4 = c.Foods.Where(x => x.CategoryId == c.Categories.Where(z => z.CategoryName == "Vegetables").Select(y => y.CategoryId).FirstOrDefault()).Count();
            ViewBag.d4 = deger4;

            //Total Food Stock
            var deger5 = c.Foods.Sum(x => x.FoodStock);
            ViewBag.d5 = deger5;

            //Total Vegetable
            //Az önce olduğu gibi idyi biz vermeden bulsun istiyoruz. Ayrıca bir değişkene atamadan da yapabiliriz.
            //Adı vegetable olan kategorinin idsini seç. Yiyecek idsi sebze idsi ile eşleşenleri tut. Say
            var deger6 = c.Foods.Where(x => x.CategoryId == c.Categories.Where(z => z.CategoryName == "Legumes").Select(y => y.CategoryId).FirstOrDefault()).Count();
            ViewBag.d6 = deger6;

            //Max Stock Food
            //Yiyecekleri tersten stoğa göre sırala. İsimlerini seç. En baştakini al.
            var deger7 = c.Foods.OrderByDescending(x => x.FoodStock).Select(y=>y.FoodName).FirstOrDefault();
            ViewBag.d7 = deger7;

            //Min Stock Food
            //Yiyecekleristoğa göre sırala. İsimlerini seç. En baştakini al.
            var deger8 = c.Foods.OrderBy(x => x.FoodStock).Select(y => y.FoodName).FirstOrDefault();
            ViewBag.d8 = deger8;

            //Food Price Average
            //Yemeklerde ortalama aldık, fiyata göre. Sonrasında virgülden sonra iki basamak olsun istediğimiz için stringe çevirirken belirttik.
            var deger9 = c.Foods.Average(x => x.FoodPrice).ToString("0.00");
            ViewBag.d9 = deger9;

            //Total Fruit Stock
            //Kategorisi Fruit olan yiyeceklerin idsini aldık. (yukarıdakini de kullanabilirdik- frid)
            //Idsi yukarıdaki değer olan yiyeceklerin, yani meyvelerin stoğunu topladık.
            var fid = c.Categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryId).FirstOrDefault();
            var deger10 = c.Foods.Where(x => x.CategoryId == fid).Sum(y => y.FoodStock);
            ViewBag.d10 = deger10;

            //Total Fruit Stock
            //Kategorisi Vegetables olan yiyeceklerin idsini aldık. (yukarıdakini de kullanabilirdik- veid)
            //Idsi yukarıdaki değer olan yiyeceklerin, yani sebzelerin stoğunu topladık.
            var vid = c.Categories.Where(x => x.CategoryName == "Vegetables").Select(y => y.CategoryId).FirstOrDefault();
            var deger11 = c.Foods.Where(x => x.CategoryId == vid).Sum(y => y.FoodStock);
            ViewBag.d11 = deger11;

            //Max Price Food
            var deger12 = c.Foods.OrderBy(x => x.FoodPrice).Select(y => y.FoodName).FirstOrDefault();
            ViewBag.d12 = deger12;

            return View();
        }
    }
}
