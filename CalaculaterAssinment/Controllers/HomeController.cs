using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalaculaterAssinment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Calculater()
        {
            return View();
        }

        public ActionResult Calculater1()
        {
            return View();
        }

        public ActionResult CalculterResult()
        {
            int a =Convert.ToInt32 (Request.QueryString["num1"]);
            int b =Convert.ToInt32 (Request.QueryString["num2"]);
            double result = 0;
            if(Request.QueryString["add"]!=null)
            {
                result = a + b;
            }
            if (Request.QueryString["sub"] != null)
            {
                result = a - b;
            }
            if(Request.QueryString["mul"] != null)
            {
                result = a * b;
            }
            if(Request.QueryString["div"] != null)
            {
               double result1 = (double)a / (double)b;
            }

            ViewBag.Result = "Your Output is    " + result;
            return View();
        }
    }
}