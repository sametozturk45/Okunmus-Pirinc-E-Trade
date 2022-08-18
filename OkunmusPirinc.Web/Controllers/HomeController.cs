using OkunmusPirinc.DatabaseAccess;
using OkunmusPirinc.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OkunmusPirinc.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Anasayfa()
        {
            List<ProductCategory> categories = new List<ProductCategory>();
            List<Product> products = new List<Product>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                categories = uow.ProductCategoryRepo.GetAll().ToList();
                products = uow.ProductRepo.ProductsWithCategories().ToList();
            }
            ListItem lists = new ListItem(products, categories);
                return View(lists);
        }
    }
}