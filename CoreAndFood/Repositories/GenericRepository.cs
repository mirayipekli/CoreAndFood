using CoreAndFood.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreAndFood.Repositories
{

    //Alacağı değer için genelde T harfi kullanılır.
    //T mutlaka bir class olmak zorunda ve new anahtar sözcüğünü barındırabilmeli.
    public class GenericRepository<T> where T:class, new()
    {
        Context c = new Context();

        //Listeleme
        public List<T> TList()
        {
            //T'den gelen değer olarak ayarla.
            return c.Set<T>().ToList();
        }


        //Ekleme
        public void TAdd(T p)
        {
            c.Set<T>().Add(p);
            c.SaveChanges();
        }


        //Silme
        public void TDelete(T p)
        {
            c.Set<T>().Remove(p);
            c.SaveChanges();
        }


        //Güncelleme
        public void TUpdate(T p)
        {
            c.Set<T>().Update(p);
            c.SaveChanges();
        }


        //İdye göre kategori getirme
        public T TGet(int id)
        {
            return c.Set<T>().Find(id);
        }

        public List<T> TList(string p) {
            return c.Set<T>().Include(p).ToList();
        }

        //Ürün veya kategori idsine göre listeleme
        public List<T> List(Expression<Func<T,bool>>filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }
    }
}
