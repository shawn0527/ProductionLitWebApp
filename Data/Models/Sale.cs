using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductionLiteWebApp.Models
{
    public class Sale
    {
        public Sale()
        {
            CreatedTime = DateTime.Now;
        }
        public int Id { get; set; }
        public int Volume { get; set; }
        public double SalePrice { get; set; }
        public string Type { get; set; }
        public int WellId { get; set; }
        public DateTime SaleTime { get; set; }
        public DateTime CreatedTime { get; set; }

        public Sale Retrieve(int saleId)
        {
            return new Sale();
        }
    }
}
