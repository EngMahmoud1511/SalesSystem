using Microsoft.EntityFrameworkCore;
using SalesMangmentSystem.Data;
using SalesMangmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesMangmentSystem.Forms
{
    public partial class Login : Form
    {
        private readonly AppContextFactory _contextFactory = new();
        private AppDbContext _context;
        public Login()
        {
            InitializeComponent();
            var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionBuilder.UseSqlServer(_contextFactory.Connection);
            _context = new AppDbContext(optionBuilder.Options);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var emp = _context.Employees.FirstOrDefault(x => x.Email == textBox2.Text);
            if (emp != null && emp.Password == textBox1.Text)
            {
                LoginSession.CurrentUser = emp;
                MessageBox.Show("Loged In Successfly");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Email or password");
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
