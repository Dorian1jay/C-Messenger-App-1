using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace messengerapp.Models
{
    public class Contacts 
    {
        public List<Person> contacts = new List<Person>()
        {
                new Person (1,"John", " walsh", "089", "1234567"),
                new Person (2,"Frank", " Grimes", "087","3453267"),
                new Person (3,"Homer", "Simpson", "089", "1255557"),
                new Person (4,"Tim", "Kennedy","019", "1214157"),
                new Person (5,"Mr", " Burns","089", "1234567"),
                new Person (6,"Carl", " Carlton","089", "1234567"),
                new Person (7,"Homer", "Simpson", "089", "1234567"),
                new Person (8,"Tim", "Kennedy","089", "1234567"),
                new Person (9,"John", " walsh","089", "1234567"),
                new Person (10,"tom", " walsh", "087", "1234567"),
         
        };

        // Checks if a number belongs to a contact
        public String SearchContacts(string AreaCode, string mobilenumber)
        {
            var contact = contacts.FirstOrDefault(x => x.AreaCode == AreaCode && x.MobileNumber == mobilenumber);

            if (contact == null)
            {
                return "error";
            }
            else
            {
                return "";
            }
        }

        // gets a contact
        public Person  getContact(string AreaCode, string mobilenumber)
        {
            var contact = contacts.FirstOrDefault(x => x.AreaCode == AreaCode && x.MobileNumber == mobilenumber);

            if (contact != null)
            {

                return contact;
            }
            else
            {
                return null;
            }

        }


    }
}