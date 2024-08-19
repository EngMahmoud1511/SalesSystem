using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.DTO
{
    internal class ItemDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int    Qty      { get; set; }
        public string CategoryName { get; set; }
    }
}
