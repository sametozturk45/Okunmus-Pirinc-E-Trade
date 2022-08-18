using OkunmusPirinc.DatabaseAccess;
using OkunmusPirinc.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OkunmusPirinc.Web.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult AnaKategoriler()
        {
            using (UnitOfWork uow = new UnitOfWork())
                return View(uow.ProductCategoryRepo.GetAll().ToList().FindAll(x=>x.MainCategoryID == null));
        }
        public ActionResult AltKategoriler(int id)
        {
            List<ProductCategory> categories = new List<ProductCategory>();
            using (UnitOfWork uow = new UnitOfWork())
                categories = uow.ProductCategoryRepo.GetAll().ToList().FindAll(x => x.MainCategoryID == id);
            if (categories.Count == 0)
                return Redirect("/Product/Urunler/"+id);
            return View(categories);
        }
    }
}