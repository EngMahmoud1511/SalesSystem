using Microsoft.EntityFrameworkCore;
using SalesMangmentSystem.Data;
using SalesMangmentSystem.Models;


namespace SalesMangmentSystem
{
    public partial class Saless : Form
    {
        Items Items = new Items();
        static double total = 0;
        Random random = new Random();
        private readonly AppContextFactory factory = new AppContextFactory();
        private readonly AppDbContext dbContext;

        public Saless()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            textBox5.TextChanged += textChanged;
            var Opt = new DbContextOptionsBuilder<AppDbContext>();
            Opt.UseSqlServer(factory.Connection);

            dbContext = new AppDbContext(Opt.Options);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox2.Text = selectedRow.Cells["Name"].Value.ToString();
                textBox4.Text = selectedRow.Cells["Qty"].Value.ToString();
                textBox5.Text = selectedRow.Cells["CategoryName"].Value.ToString();
            }
        }
        private void textChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = (total - double.Parse(textBox5.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Enter A valied Number");
            }


        }
        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void Sales_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = Items.Purchases;
            //Guid guid = Guid.NewGuid();
            //textBox3.Text = guid.ToString();
            //foreach (var item in Items.Purchases)
            //{
            //    total = total + item.Price;
            //}
            //textBox4.Text = total.ToString();
            //textBox2.Text = LoginSession.CurrentUser.Name;
            //textBox7.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.SalePrice = double.Parse(textBox4.Text);
            sales.PillNum = random.Next(10000000,99999999);
            sales.SaleDate = Convert.ToDateTime(textBox7.Text);
            sales.AmountPaid = double.Parse(textBox5.Text);
            dbContext.Sales.Add(sales);
            dbContext.SaveChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
