using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace messengerapp.Models
{
    public class Person
    {
        //fields

        private int id;       
        private string forename;
        private string surname;
        private string areaCode;
        private string mobileNumber;

        // getters and setters 
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Forename
        {
            get { return forename; }
            set { forename = value; }
        }

        
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        
        public string AreaCode
        {
            get { return areaCode; }
            set { areaCode = value; }
        }

        
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        ///////////////constructors
        public Person()
        {
                
        }

        public Person(int i,string fname, string sname, string code, string num)
        {
            this.id = i;
            this.forename = fname;
            this.surname = sname;
            this.areaCode = code;
            this.mobileNumber = num;

        }


    }

}