using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels.Models;
using ViewModels.ViewModel;

namespace ViewModels.Controllers
{
    public class DogController : Controller
    {
        public static List<Dog> dogsList = new List<Dog>();
        public static List<Fur> furList = new List<Fur>();

        public static List<DogFurViewModel> dogsAndFurList = new List<DogFurViewModel>();


        // GET: Fur
        public ActionResult Index()
        {
            var activeFelleLeine = furList.Where(x => x.Active == true).ToList();
            return View(activeFelleLeine);
        }

        // GET: Dog
        public ActionResult Index2()
        {
            var activeHundeLeine = dogsList.Where(x => x.IsActive == true).ToList();
            return View(activeHundeLeine);
        }



        // GET: Dog and Fur
        // Verbinden von Dog und Fur
        // ViewModel selbst wird nicht in der DB gespeichert
        public ActionResult Index3()
        {
            dogsAndFurList.Clear();

            foreach (var item in dogsList)
            {
                DogFurViewModel model = new DogFurViewModel
                {
                    DogAdress = item,
                    FurAdress = furList.Where(x => x.Id == item.FurId).FirstOrDefault(),
                    Timestamp = DateTime.Now
                };
                dogsAndFurList.Add(model);
            }
            return View(dogsAndFurList);
        }



        // GET: Dog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dog/Create
        [HttpPost]
        public ActionResult Create(int age, string name, double legs, int furId)
        {
            try
            {
                Dog dog = new Dog
                {
                    Age = age,
                    Name = name,
                    Legs = legs,
                    FurId = furId
                };

                dogsList.Add(dog);

                return RedirectToAction("Index2");
            }
            catch
            {
                return View("error");
            }
        }

        // GET: Dog/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dog/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dog/Delete/5
        public ActionResult Delete(int id)
        {
            dogsList[id - 1].IsActive = false;
            return RedirectToAction("index2");
        }

        // POST: Dog/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
