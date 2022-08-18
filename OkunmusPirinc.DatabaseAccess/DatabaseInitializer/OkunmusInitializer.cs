using OkunmusPirinc.DatabaseAccess.DatabaseAccess;
using OkunmusPirinc.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkunmusPirinc.DatabaseAccess.DatabaseInitializer
{
    public class OkunmusInitializer : DropCreateDatabaseAlways<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            string kahve= "";
            for(int i = 0; i < 250; i++)
                kahve += " kahve";
            ProductCategory cat= context.Set<ProductCategory>().Add(new ProductCategory {CategoryID = 1, CategoryName = "İçecekler"});
            ProductCategory cat1 = context.Set<ProductCategory>().Add(new ProductCategory { CategoryID =2, CategoryName = "Şalgamlar",MainCategoryID = cat.CategoryID});
            ProductCategory cat2 = context.Set<ProductCategory>().Add(new ProductCategory { CategoryID =3, CategoryName = "Soğuk İçecekler",MainCategoryID = cat.CategoryID});
            ProductCategory cat3 = context.Set<ProductCategory>().Add(new ProductCategory { CategoryID =4, CategoryName = "Sıcak İçecekler",MainCategoryID = cat.CategoryID});
            ProductCategory cat4 = context.Set<ProductCategory>().Add(new ProductCategory { CategoryID =5, CategoryName = "Kokteyller",MainCategoryID = cat.CategoryID});
            ProductCategory cat5= context.Set<ProductCategory>().Add(new ProductCategory {CategoryID = 6, CategoryName = "Yiyecek"});
            ProductCategory cat6 = context.Set<ProductCategory>().Add(new ProductCategory { CategoryID =7, CategoryName = "Tostlar",MainCategoryID = cat5.CategoryID});
            context.Set<Product>().Add(new Product { ProductName = "Hacının Şalgamı", ProductDesc = "Hacının şalgamı 1 numara", ProductPrice = 150, Category = cat1 });
            context.Set<Product>().Add(new Product { ProductName = "Pepsi", ProductDesc = "Pepsi", ProductPrice = 150, Category = cat2 });
            context.Set<Product>().Add(new Product { ProductName = "Kahve", ProductDesc = kahve, ProductPrice = 150, Category = cat3 });
            context.Set<Product>().Add(new Product { ProductName = "Portakal Suyu", ProductDesc = "Portakal Suyu", ProductPrice = 150, Category = cat4 });
            context.Set<Product>().Add(new Product { ProductName = "Kaşarlı Tost", ProductDesc = "Kaşarlı Tost", ProductPrice = 150, Category = cat6 });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
