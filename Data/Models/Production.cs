using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductionLiteWebApp.Models
{
    public class Production
    {
        public Production()
        {
            CreatedTime = DateTime.Now;
        }
        public int Id { get; set; }
        public int Volume { get; set; }
        public string Type { get; set; }
        public int WellId { get; set; }
        public DateTime ProductionTime { get; set; }
        public DateTime CreatedTime { get; set; }

        public Production Retrieve(int productionId)
        {
            return new Production();
        }
    }
}
