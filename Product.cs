using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignmentDay4
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? PName { get; set; }
        public decimal PPrice { get; set; }
        public string? PBrand { get; set; }
        public DateTime MfgDate { get; set; }
        public DateTime ExpDate { get; set; }
    }
}