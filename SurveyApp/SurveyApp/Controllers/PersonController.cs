using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurveyApp.Models;
using SurveyApp.Models.ViewModels;

namespace SurveyApp.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            using (var db = new SurveyDBEntities())
            {
                var people = db.Set<Person>()
                    .OrderByDescending(p => p.Age)
                    .ThenBy(p => p.FullName)
                    .ToList();
                return View(people);
            }
        }

        // GET: Person/Details/{id}
        public ActionResult Details(Guid id)
        {
            using (var db = new SurveyDBEntities())
            {
                var person = db.Set<Person>().Find(id);
                if (person == null)
                {
                    return HttpNotFound();
                }
                return View(person);
            }
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            ViewBag.GenderList = GetGenderList();
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonVM personVM)
        {
            if (ModelState.IsValid)
            {
                using (var db = new SurveyDBEntities())
                {
                    var person = new Person
                    {
                        Id = Guid.NewGuid(),
                        FullName = personVM.FullName,
                        Age = personVM.Age,
                        Gender = personVM.Gender,
                        HasJob = personVM.HasJob
                    };

                    db.Set<Person>().Add(person);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            ViewBag.GenderList = GetGenderList();
            return View(personVM);
        }

        private List<Tuple<string, string>> GetGenderList()
        {
            return new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Мужской", "Мужской"),
                new Tuple<string, string>("Женский", "Женский")
            };
        }
    }
}