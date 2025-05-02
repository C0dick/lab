using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLab1.Controllers
{
    public class VegetablesController : Controller
    {
        // GET: Vegetables/FirstView
        public ActionResult FirstView()
        {
            List<string> vegetables = new List<string>
            {
                "Морковь", "Картофель", "Лук", "Помидор", "Огурец",
                "Капуста", "Баклажан", "Кабачок", "Свекла", "Редис"
            };
            return View(vegetables);
        }

        // GET: Vegetables/SecondView
        public ActionResult SecondView()
        {
            List<string> vegetables = new List<string>
            {
                "Морковь", "Картофель", "Лук", "Помидор", "Огурец",
                "Капуста", "Баклажан", "Кабачок", "Свекла", "Редис"
            };
            vegetables.Sort();
            return View(vegetables);
        }

        // GET: Vegetables/ThirdView
        public ActionResult ThirdView()
        {
            List<string> vegetables = new List<string>
            {
                "Морковь", "Картофель", "Лук", "Помидор", "Огурец",
                "Капуста", "Баклажан", "Кабачок", "Свекла", "Редис"
            };
            vegetables.Sort();
            return View(vegetables);
        }
    }
}