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

namespace SalesMangmentSystem
{


    public partial class Customers : Form
    {
        public AppDbContext _context;
        private readonly AppContextFactory Factory = new();

        public Customers()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(Factory.Connection);

            _context = new AppDbContext(optionsBuilder.Options);

            // Subscribe to the SelectionChanged event
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        // Load event for the form
        public void Form2_Load(object sender, EventArgs e)
        {
            var customers = _context.Customers.ToList();
            dataGridView1.DataSource = customers;
        }

        // Event handler for DataGridView selection change
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                textBox1.Text = selectedRow.Cells["FirstName"].Value.ToString();
                textBox2.Text = selectedRow.Cells["LastName"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Address"].Value.ToString();
                textBox4.Text = selectedRow.Cells["CivilNo"].Value.ToString();


                Gender gender = (Gender)selectedRow.Cells["Gender"].Value;
                if (gender == Gender.Mail)
                {
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                }
                else
                {
                    checkBox1.Checked = false;
                    checkBox2.Checked = true;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int customerId = (int)selectedRow.Cells["Id"].Value;

                var customer = _context.Customers.Find(customerId);
                if (customer != null)
                {
                    _context.Remove(customer);
                    _context.SaveChanges();

                    dataGridView1.DataSource = _context.Customers.ToList();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int customerId = (int)selectedRow.Cells["Id"].Value;

                var customer = _context.Customers.Find(customerId);
                if (customer != null)
                {
                    customer.FirstName = textBox1.Text;
                    customer.LastName = textBox2.Text;
                    customer.Address = textBox3.Text;
                    customer.CivilNo = textBox4.Text;
                    customer.Gender = checkBox1.Checked ? Gender.Mail : Gender.Femail;

                    _context.Update(customer);
                    _context.SaveChanges();

                    dataGridView1.DataSource = _context.Customers.ToList();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        // Event handler for Add button
        private void button4_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Address = textBox3.Text,
                CivilNo = textBox4.Text,
                Gender = checkBox1.Checked ? Gender.Mail : Gender.Femail
            };

            _context.Customers.Add(customer);
            _context.SaveChanges();

            MessageBox.Show("Customer Added Successfully");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;

            dataGridView1.DataSource = _context.Customers.ToList();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
