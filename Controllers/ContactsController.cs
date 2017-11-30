using messengerapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace messengerapp.Controllers
{
    public class ContactsController : Controller
    {

        Contacts contactslist = new Contacts();
        // GET: Contacts
        public ActionResult Index()
        {
            
            return View(contactslist.contacts);
            
        }

        // Sends a mobile number to SMS view
        public ActionResult SendMessage(String AreaCode, String MobileNumber)
        {
            SMS Sms = new SMS();
            AreaCode = Sms.AreaCode;
            MobileNumber = Sms.MobileNumber;
            return View("~/Views/SMS/index.cshtml",Sms);
            //return RedirectToAction("aIndex","SMS",Sms);

            //var controller = DependencyResolver.Current.GetService<SMSController>();
            //var result = controller.Index(Message);
            //return result;

        }
    }
}