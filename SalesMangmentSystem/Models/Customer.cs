﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.Models
{
    public enum Gender
    {
        Femail,
        Mail
    }
    internal class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Address { get; set; }
        public string CivilNo { get; set; } 
        public Gender Gender { get; set; }

    }
}
