using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeASPNET.Models
{
    public class Register
    {

        private string firstname;
        private string lastname;
        private string email;
        private string password;

        public Register()
        {
            firstname = "";
            lastname = "";
            email = "";
            password = "";

        }

        public Register(string firstname, string lastname, string email, string password)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;
        }

        public string FirstName
        {
            set { firstname = value; }
            get { return firstname; }
        }

        public string LastName
        {
            set { lastname = value; }
            get { return lastname; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }
    }
}