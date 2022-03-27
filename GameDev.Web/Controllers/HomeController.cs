using GameDev.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameDev.Web.Controllers
{
    public class HomeController : Controller
    {   //to access the Inmemorycompanydata.cs component so that we can build model a/c to user request to transfer it to view for rendering
        ICompanyData db; //controller is going to access the database thru this interface
        public HomeController() //to initialize above field
        {
            db = new InMemoryCompanyData();
        }
        public ActionResult Index()
        {
            var model = db.GetAll();//my model will just be telling get all the resturants inside the database
            return View(model);//passing this model into view
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
    }
}