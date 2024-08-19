using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.Models
{
    internal class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
       
        public int CategoryId { get; set; }
        public Category Category { get; set; }



    }
}
