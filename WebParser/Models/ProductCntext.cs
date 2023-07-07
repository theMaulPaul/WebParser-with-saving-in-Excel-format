using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebParser.Models
{
    public class ProductCntext: DbContext
    {
        public DbSet<Product> Products { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;InitialCatalog=WebStore;IntegratedSecurity=True;Connect Timeout=30;Encrypt=False;");
        }
    }
}
