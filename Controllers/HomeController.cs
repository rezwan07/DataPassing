using DataPassing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataPassing.Controllers
{
    public class HomeController : Controller
    {
         //GET: Home
        //public ActionResult Index()
        //{
        //    //Person person = new Person();
        //    //person.Name="rez2";
        //    //person.Salary = 120000;

        //    List<Person> people = new List<Person>()
        //    {
        //        new Person() {Name="rez1" , Salary= 1111111},
        //        new Person() {Name="rez2" , Salary= 2222222},
        //    };

        //    //TempData["Name"] = "rez1";
        //    return View(people);
        //}

        public ActionResult Index()
        {
            if (Request.HttpMethod=="GET")
            {
                return View("index");
            }
            return Content(Request["name"]);
            //return View();
        }

        //public ActionResult Another()
        //{
        //    return View();
        //}
    }
}