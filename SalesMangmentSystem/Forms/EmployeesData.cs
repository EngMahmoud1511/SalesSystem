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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesMangmentSystem.Forms
{
    public partial class EmployeesData : Form
    {
        private readonly AppContextFactory factory = new();
        private AppDbContext _dbContext;
        public EmployeesData()
        {
            InitializeComponent();
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(factory.Connection);
            _dbContext = new AppDbContext(optionsBuilder.Options);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox1.Text = selectedRow.Cells["Name"].Value.ToString();
                textBox2.Text = selectedRow.Cells["Email"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Password"].Value.ToString();
                textBox4.Text = selectedRow.Cells["Rool"].Value.ToString();

            }
        }
        private void EmployeesData_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _dbContext.Employees.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee employee = new()
            {
                Name = textBox1.Text,
                Email = textBox2.Text,
                Password = textBox3.Text,
                Rool = textBox4.Text

            };
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            dataGridView1.DataSource = _dbContext.Employees.ToList();
             

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int EmpId = (int)selectedRow.Cells["Id"].Value;
                var emp = _dbContext.Employees.Find(EmpId);
                if (emp != null)
                {
                    emp.Name = textBox1.Text;
                    emp.Email = textBox2.Text;
                    emp.Password = textBox3.Text;
                    emp.Rool = textBox4.Text;
                    _dbContext.Employees.Update(emp);
                    _dbContext.SaveChanges();
                    dataGridView1.DataSource = _dbContext.Employees.ToList();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                }
            }
            else
            {
                MessageBox.Show("Sellect a Row to update");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int EmpId = (int)selectedRow.Cells["Id"].Value;
                var emp = _dbContext.Employees.Find(EmpId);
                if (emp != null)
                {
                    _dbContext.Remove(emp);
                    _dbContext.SaveChanges();
                    dataGridView1.DataSource = _dbContext.Employees.ToList();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();   
                    textBox4.Clear();  
                    
                }
            }
            else
            {
                MessageBox.Show("Sellect a Row to update");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
