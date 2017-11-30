using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace messengerapp.Models
{
    public class SMS
    {
       


        // Area Code property for area code of contact with validation
        [Display(Name = "Area Code")]
        [Required(ErrorMessage = "You must enter a valid area code e.g. 085")]
        [RegularExpression("^08[3-9]$", ErrorMessage = "Please enter a valid 3 digit area code")]
        public string AreaCode { get; set; }

        // mobile Number property for phone number of contact with validation
        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "You must enter a valid phone number e.g. 1234567")]
        [RegularExpression("^[0-9][0-9][0-9][0-9][0-9][0-9][0-9]$", ErrorMessage = "Please enter a valid 7 digit phone number")]
        public string MobileNumber { get; set; }

        // Message property for text content of message with validation
        [Display(Name = "Message")]
        [Required(ErrorMessage = "Enter a message between 1 and 140 characters")]
        [StringLength(140, MinimumLength = 1, ErrorMessage = "There must be between 1 and 140 characters in your message.")]
        public string Message { get; set; }


        //////constructors

        public SMS()
        {

        }

        public SMS( string ac,string no, string s)
        {
           
            this.AreaCode = ac;
            this.MobileNumber = no;
            this.Message = s;
        }

    }
}