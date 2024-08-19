using Microsoft.EntityFrameworkCore;
using SalesMangmentSystem.Data;
using SalesMangmentSystem.Forms;
using SalesMangmentSystem.Models;

namespace SalesMangmentSystem
{
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (LoginSession.IsUserLoggedIn() == true)
            {
                Items items = new Items();
                items.Show();
            }
            else
            {
                Login login = new Login();
                login.Show();
            }

            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (LoginSession.IsUserLoggedIn())
            {
                Categories categories = new Categories();
                categories.Show();
            }
            else
            {
                Login login=new Login();
                login.Show();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (LoginSession.IsUserLoggedIn())
            {
                Customers customers = new();
                customers.Show();
            }
            else
            {
                Login Login = new Login();
                Login.Show();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (LoginSession.IsUserLoggedIn())
            {
                Saless saless = new();
                saless.Show();
            }
            else
            {
                Login Login = new Login();
                Login.Show();
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            LoginSession.Logout();

        }
        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (LoginSession.IsUserLoggedIn() && LoginSession.CurrentUser.Rool == "Admin")
            {
                EmployeesData employees = new EmployeesData();
                employees.Show();
            }
            else if (LoginSession.IsUserLoggedIn() )
            {
                MessageBox.Show("Access not allawed");
            }
            else
            {
                Login Login = new Login();
                Login.Show();
            }
            
              
        }
    }
}
