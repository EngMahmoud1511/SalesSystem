using Microsoft.EntityFrameworkCore;
using SalesMangmentSystem.Data;
using SalesMangmentSystem.Models;
using SalesMangmentSystem.DTO;
using System.Collections.Generic;

namespace SalesMangmentSystem
{
    public partial class Items : Form
    {
       
        public AppDbContext _context;
        private readonly AppContextFactory Factory = new();
        public Items()
        {
            InitializeComponent();
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(Factory.Connection);

            _context = new AppDbContext(optionsBuilder.Options);

            // Subscribe to the SelectionChanged event
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox2.Text = selectedRow.Cells["Name"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Price"].Value.ToString();
                textBox4.Text = selectedRow.Cells["Qty"].Value.ToString();
                
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Items_Load(object sender, EventArgs e)
        {
            Items_Data();

        }
        public void Items_Data()
        {
            List<ItemDTO> items = new List<ItemDTO>();
            var itemlist = _context.Items.ToList();
              foreach (var item in itemlist)
                {
                    ItemDTO itemDTO = new ItemDTO();
                    itemDTO.ID = item.Id;
                    itemDTO.Name = item.Name;
                    itemDTO.Price = item.Price;
                    itemDTO.Qty = item.Qty;
                    itemDTO.CategoryName = _context.Categories.FirstOrDefault(x => x.Id == item.CategoryId).Name;
                    items.Add(itemDTO);


                }
            
            
            dataGridView1.DataSource = items;
            dataGridView1.Columns["Id"].Visible = false;
            var categories=_context.Categories.ToList();
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int ItemId = (int)selectedRow.Cells["Id"].Value;
               

                var item = _context.Items.Find(ItemId);
                if (item != null)
                {
                    _context.Remove(item);
                    _context.SaveChanges();
                    
                }
                Items_Data();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int ItemId = (int)selectedRow.Cells["Id"].Value;
                var item = _context.Items.Find(ItemId);
                if (item != null)
                {
                    item.Name = textBox2.Text;
                    item.Qty = int.Parse(textBox4.Text);
                    item.Price = int.Parse(textBox3.Text);
                    Category selectedCategory = comboBox1.SelectedItem as Category;
                    int selectedCategoryId = selectedCategory.Id;
                    item.CategoryId =selectedCategoryId;
                    _context.Update(item);
                    _context.SaveChanges();
                    
                }
                Items_Data();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var category = _context.Categories.FirstOrDefault(x => x.Id == (int)comboBox1.SelectedItem);

                if (category != null)
                {
                    Item item = new()
                    {
                        Name = textBox2.Text,
                        Qty = int.Parse(textBox4.Text),
                        Price = int.Parse(textBox3.Text),
                        CategoryId = category.Id
                    };
                    _context.Add(item);
                    _context.SaveChanges();
                    Items_Data();
                }
            }

            else
            {
                MessageBox.Show("Sllect a valid catgory");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          

        }
    }
}
