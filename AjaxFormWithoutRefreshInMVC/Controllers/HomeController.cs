using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxFormWithoutRefreshInMVC.Models;
using Newtonsoft.Json;

namespace AjaxFormWithoutRefreshInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Index(Employee model)
        {
            return Json("true", JsonRequestBehavior.AllowGet);
        }

        public ActionResult List()
        {
            return View();
        }
        public JsonResult Countries()
        {
            List<string> countries = new List<string>()
            {
                "Afghanistan",
                "Albania",
                "Algeria",
                "Andorra",
                "Angola",
                "AntiguaandBarbuda",
                "Argentina",
                "Armenia",
                "Australia",
                "Austria",
                "Azerbaijan"
            };
            var json = JsonConvert.SerializeObject(countries);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
        public JsonResult States()
        {
            List<string> states = new List<string>()
            {
                "State -- Afghanistan",
                "State -- Albania",
                "State -- Algeria",
                "State -- Andorra",
                "State -- Angola",
                "State -- AntiguaandBarbuda",
                "State -- Argentina",
                "State -- Armenia",
                "State -- Australia",
                "State -- Austria",
                "State -- Azerbaijan"
            };
            var json = JsonConvert.SerializeObject(states);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
        public JsonResult City()
        {
            List<string> City = new List<string>()  
            {
                "City -- Afghanistan",
                "City -- Albania",
                "City -- Algeria",
                "City -- Andorra",
                "City -- Angola",
                "City -- AntiguaandBarbuda",
                "City -- Argentina",
                "City -- Armenia",
                "City -- Australia",
                "City -- Austria",
                "City -- Azerbaijan"
            };
            var json = JsonConvert.SerializeObject(City);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}