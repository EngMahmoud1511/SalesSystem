using Microsoft.EntityFrameworkCore;
using SalesMangmentSystem.Data;
using SalesMangmentSystem.DTO;
using SalesMangmentSystem.Models;
  
namespace SalesMangmentSystem
{
    public partial class Categories : Form
    {

        private readonly AppDbContext _context;
        AppContextFactory Factory = new();
        public Categories()
        {
            InitializeComponent();
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(Factory.Connection);
            _context = new AppDbContext(optionsBuilder.Options);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             dataGridView1_Data();
        }
        private void dataGridView1_Data() 
        { 
            var categories=_context.Categories.ToList();
            dataGridView1.DataSource= categories;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Items"].Visible = false;
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox2.Text = selectedRow.Cells["Name"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           
                Category category = new()
                {
                    Name = textBox2.Text
                };

                _context.Categories.Add(category);
                _context.SaveChanges();
                dataGridView1_Data();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int id = (int)selectedRow.Cells["Id"].Value;
                var category = _context.Categories.Find(id);
                if (category != null)
                {
                    category.Name = textBox2.Text;
                    _context.Update(category);
                    _context.SaveChanges();
                    dataGridView1_Data();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int Id = (int)selectedRow.Cells["Id"].Value;
                var category = _context.Categories.Find(Id);
                if (category != null)
                {
                    _context.Remove(category);
                    _context.SaveChanges();
                    dataGridView1_Data();

                }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
