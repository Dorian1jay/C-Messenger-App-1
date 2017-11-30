using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using messengerapp.Models;

namespace messengerapp.Controllers
{
    public class PersonController : Controller
    {
        IList<Person> contacts = new List<Person>
            {
                new Person (1,"John", " walsh", "089", "1234567"),
                new Person (2,"Frank", " Grimes", "087","1234567"),
                new Person (3,"Homer", "Simpson", "089", "1234567"),
                new Person (4,"Tim", "Kennedy","089", "1234567"),
                new Person (5,"Mr", " Burns","089", "1234567"),
                new Person (6,"Carl", " Carlton","089", "1234567"),
                new Person (7,"Homer", "Simpson", "089", "1234567"),
                new Person (8,"Tim", "Kennedy","089", "1234567"),
                new Person (9,"John", " walsh","089", "1234567"),
                new Person (10,"tom", " walsh", "087", "1234567"),

            };


        // GET: Person
        public ActionResult IndexView()
        {
            return View(contacts);
        }

        public ActionResult Create(Person p)
        {
            var fname = p.Forename;
            var sname = p.Surname;
            var acode = p.AreaCode;
            var mno = p.MobileNumber;
            
            return View();
        }
        public ActionResult Edit(string forename)
        {
          
            var std = contacts.Where(p => p.Forename == forename).FirstOrDefault();
            return View(std);

        }
        [HttpPost]
        public ActionResult Edit(Person p)
        {
            //write code to update student 

            return RedirectToAction("IndexView");
        }

        
    }

}