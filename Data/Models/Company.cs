using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductionLiteWebApp.Models
{
    public class Company
    {
        public Company()
        {
            CreatedTime = DateTime.Now;
        }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public List<User> UserList { get; set; }
        public string  SubscriptionLevel { get; set; }
        public DateTime CreatedTime { get; set; }

        public Company Retrieve(int companyId)
        {
            return new Company();
        }
    }
}
