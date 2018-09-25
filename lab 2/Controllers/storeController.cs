using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_2.Controllers
{
    public class storeController : Controller
    {
        // GET: store
        public ActionResult Index()
        {
            return View();
        }
		// GET: Store/Product
		public ActionResult product(String Products)
		{
			ViewBag.Products = Products;
			return View();
			}
    }
}