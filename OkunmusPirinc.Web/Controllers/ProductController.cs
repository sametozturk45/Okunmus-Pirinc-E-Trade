using OkunmusPirinc.DatabaseAccess;
using OkunmusPirinc.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OkunmusPirinc.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult TumUrunler(int page = 1)
        {
            List<ProductCategory> categories = new List<ProductCategory>();
            List<Product> products = new List<Product>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                categories = uow.ProductCategoryRepo.GetAll().ToList();
                products = uow.ProductRepo.ProductsWithCategories().Skip((page - 1) * 12).Take(12).ToList();
            }
            ListItem lists = new ListItem(products, categories);
            return View(lists);
        }
        public ActionResult Urunler(int id, int page = 1)
        {
            List<ProductCategory> categories = new List<ProductCategory>();
            List<Product> products = new List<Product>();
            ListItem lists = new ListItem(2);
            int productCount = 0;
            using (UnitOfWork uow = new UnitOfWork())
            {
                categories = uow.ProductCategoryRepo.GetAll().ToList();
                productCount = uow.ProductRepo.ProductsWithCategories().ToList().FindAll(x => x.CategoryID == id || x.Category.MainCategoryID == id).Count;
                products = uow.ProductRepo.ProductsWithCategories().ToList().FindAll(x => x.CategoryID == id || x.Category.MainCategoryID == id).Skip((page - 1) * lists.ItemPerPage).Take(lists.ItemPerPage).ToList();
            }
            lists.Products = products;
            lists.Categories = categories;
            lists.CurrentPage = page;
            if (productCount != 0)
            {
                if (productCount % lists.ItemPerPage == 0)
                {
                    lists.PageCount = productCount / lists.ItemPerPage;
                }
                else
                {
                    lists.PageCount = productCount / lists.ItemPerPage + 1;
                }
            }
            else
                lists.PageCount = 1;
            return View(lists);
        }

        public ActionResult UrunDetay(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
                return View(uow.ProductRepo.GetItemWithCategory(id));
        }
    }
}