using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLinq
{
    public partial class Form3 : Form
    {
        NorthwindDataContext dc = new NorthwindDataContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var categories = from c in dc.Categories select new { c.CategoryID, c.CategoryName };
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
            comboBox1.DataSource = categories;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                int categoryID = int.Parse(comboBox1.SelectedValue.ToString());
                var product = from p in dc.Products
                              where p.CategoryID == categoryID
                              select p;
                dataGridView1.DataSource = product;
           
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int productId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var result = from p in dc.Products
                         join ordet in dc.Order_Details on p.ProductID equals ordet.ProductID
                         join order in dc.Orders on ordet.OrderID equals order.OrderID
                         join ship in dc.Shippers on order.ShipVia equals ship.ShipperID
                         where p.ProductID == productId
                         select new
                         {
                             p.ProductName,
                             ship.CompanyName,
                             order.ShipCountry,
                             order.OrderDate
                         };
            dataGridView2.DataSource = result;
        }
    }
}
