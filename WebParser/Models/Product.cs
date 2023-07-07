using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebParser.Models
{
    [Index(nameof(Code), IsUnique = true)]
    public class ProductContext
    { 
        public int Id { get; set; }
        public bool Availability { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Price { get; set; }
        public string Details { get; set; } 
        public decimal Vendor { get; set; }
        public string ImageUrl{ get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
