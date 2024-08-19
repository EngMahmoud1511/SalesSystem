using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.Models
{
    [PrimaryKey(nameof(OrderId),nameof(ItemId))]
    internal class OrderItem
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public Orders Orders { get; set; }


    }
}
