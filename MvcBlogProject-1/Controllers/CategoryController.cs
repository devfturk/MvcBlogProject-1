using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject_1.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager();
        // GET: Category
        public ActionResult Index()
        {
            var categories = categoryManager.GetAll();
            return View(categories);
        }
        public PartialViewResult BlogDetailsCategoryList()
        {
            return PartialView();
        }
    }
}