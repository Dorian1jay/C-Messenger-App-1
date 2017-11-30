using messengerapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace messengerapp.Controllers
{
    public class SMSController : Controller
    {
        Models.Contacts contactslist = new Contacts();

        // GET: SMS
        public ActionResult Index()
        {
            return View();
        }

        //
        
        //[ActionName("Get from sms")]        
        //public ActionResult Index(SMS Sms)
        //{
        //    return View( Sms);
        //}

        //// POST: SMSTextMessage
        //[HttpPost]
        //public ActionResult Index(Models.SMS sms)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // findContact returns error, an error message is broadcast to the screen.
        //        // otherwise it broadcasts a success message

        //        string findContact = contactslist.SearchContacts(sms.AreaCode, sms.MobileNumber);

        //        if (findContact == "error")
        //        {
        //            ViewData["ValidMessage"] = "Error. Contact does not exist. Please see contacts page for valid contacts";
        //            return View();
        //        }
        //        else
        //        {
        //            ViewData["ValidMessage"] = "Message was successfully sent.";
        //        }
        //    }
        //    return View(sms);
        //}

        



        // POST: SMS
        [HttpPost]
        public ActionResult Index(SMS sms)
        {
            if (ModelState.IsValid)
            {
                // findContact returns error, an error message is broadcast to the screen.
                // otherwise it broadcasts a success message

                Person contact = contactslist.getContact(sms.AreaCode, sms.MobileNumber);

                if (contact != null)
                {
                    //get confirmation view  pass in contact
                    return View("~/Views/SMS/Confirmation.cshtml", contact);
                }
                else
                {
                    // return error view 
                    return View("~/Views/SMS/Error.cshtml");
                   
                }
            }
            return View(sms);
        }


    }
}
