using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NineEntertainmentCoDeveloperTest.Models;
using NineEntertainmentCoDeveloperTest.Services;

namespace NineEntertainmentCoDeveloperTest.Controllers
{
    public class PersonController : Controller
    {

        private readonly ILoggerService _loggerService;
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService, ILoggerService loggerService)
        {
            _personService = personService;
            _loggerService = loggerService;

        }
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult GetPeopleRaces(int Raceid)
        {
            var peoplelist = new List<Person>();
            try
            {
                peoplelist = _personService.GetPersonsByRace(_personService.GetRace(Raceid));
            }

            catch (Exception ex)
            {
                _loggerService.Handle("", ex.ToString());
            }
            return PartialView(peoplelist);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }



        // POST: Person/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult People()
        {
            return PartialView();
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}