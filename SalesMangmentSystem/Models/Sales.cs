
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.Models
{
    internal class Sales
    {
        public int Id { get; set; }
        public int PillNum { get; set; }
        public DateTime SaleDate { get; set; }
        public int[] ItemsId {  get; set; } 
        public double SalePrice { get; set; }
        public double AmountPaid { get; set; }


    }
}
