using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductionLiteWebApp.Models
{
    public class PhoneNumber
    {
        public PhoneNumber()
        {
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string CellPhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }

        public Object Retrieve(User user)
        {
            return new object();
        }
    }
}
