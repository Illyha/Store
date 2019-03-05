using BusinessLogicLayer;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyBll bll = new MyBll();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var result = bll.GetCountriesByConcreteMark("sddd");


            return View();
        }
        [HttpPost]
        public ActionResult About(AboutModel model)
        {
            var result = bll.GetProducersCountByConcreteMark(model.ConcreteMark);
            model.Quantity = result;
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}