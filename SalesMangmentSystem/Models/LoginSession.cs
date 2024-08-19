using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.Models
{
    
        public static class LoginSession
        {
            internal static Employee CurrentUser { get; set; }

            public static bool IsUserLoggedIn()
            {
                return CurrentUser != null;
            }

            public static void Logout()
            {
                CurrentUser = null;
            }
        }

    
}
