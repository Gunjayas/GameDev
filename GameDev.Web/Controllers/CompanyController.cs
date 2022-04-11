using GameDev.Data.Model;
using GameDev.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameDev.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyData db;

        public CompanyController(ICompanyData db)
        {
            this.db = db;
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                db.Add(company);
                return RedirectToAction("Details", new {id = company.Id } );

            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
         
        }

        [HttpPost]
        public ActionResult Edit(Company company)
        {
            if(ModelState.IsValid)
            {
                db.Update(company);
                TempData["Message"] = "You have saved the company";
                return RedirectToAction("Details", new { id = company.Id });
            }
            return View(company);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}