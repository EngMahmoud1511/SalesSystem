using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.Data
{
    public class AppContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public string Connection = "Data Source=DESKTOP-2RDLSV1;Initial Catalog=SalesSystemDB;" +
            "Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False" +
            ";Application Intent=ReadWrite;Multi Subnet Failover=False";
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(Connection);

            return new AppDbContext(optionsBuilder.Options);
        }
    }

}
