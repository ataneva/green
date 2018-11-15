using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using WebApplicationGreenwheel.Helpers;

namespace WebApplicationGreenwheels.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string hours, string km, string carDropDownList)
        {
            if (!Regex.IsMatch(hours, @"^\d+$") || !Regex.IsMatch(km, @"^\d+$"))
            {
                return View();
            }
            var result = Calculation.CalculateTariff(Convert.ToInt32(hours), Convert.ToInt32(km), carDropDownList);

            return View(result);
        }
    }
}