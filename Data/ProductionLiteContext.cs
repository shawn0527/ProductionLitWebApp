using Microsoft.EntityFrameworkCore;
using ProductionLiteWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductionLiteWebApp.Data
{
    public class ProductionLiteContext : DbContext
    {
        public ProductionLiteContext(DbContextOptions<ProductionLiteContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Well> Wells { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<ProductionLiteWebApp.Models.PhoneNumber> PhoneNumber { get; set; }
    }
}
