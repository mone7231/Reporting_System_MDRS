using Reporting_System_MDRS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reporting_System_MDRS.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private ApplicationDbContext _context = new ApplicationDbContext();

        [HttpGet]
        public ActionResult Index()
        {
            var categories = _context.category.ToList();
            return Json(categories, JsonRequestBehavior.AllowGet);
        }
    }
}