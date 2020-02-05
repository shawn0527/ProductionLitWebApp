using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductionLiteWebApp.Models
{
    public class User
    {
        public User()
        {
            CreatedTime = DateTime.Now;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = FirstName + " " + LastName;
                return fullName;
            }
        }
        public string EmailAddress { get; set; }
        public int CompanyId { get; set; }
        public PhoneNumber PhoneNumbers { get; set; }
        public bool Admin { get; set; }
        public string Password { get; set; }
        public DateTime CreatedTime { get; set; }

        public User Retrieve(int userId)
        {
            return new User();
        }

        public List<User> Retrieve()
        {
            return new List<User>();
        }
    }
}
