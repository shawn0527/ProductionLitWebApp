using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductionLiteWebApp.Models
{
    public class Well
    {
        public Well()
        {
            CreatedTime = DateTime.Now;
        }
        public int Id { get; set; }
        public int API { get; set; }
        public string WellName { get; set; }
        public int TD { get; set; }
        public int TVD { get; set; }
        public string Field { get; set; }
        public string WellType { get; set; }
        public List<Production> Productions { get; set; }
        public List<Sale> Sales { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedTime { get; set; }

        public Well Retrieve(int wellId)
        {
            return new Well();
        }
    }
}
