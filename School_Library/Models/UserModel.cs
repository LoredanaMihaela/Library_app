using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Library.Models
{
    public class UserModel
    {
        public Guid IDUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
    }
}