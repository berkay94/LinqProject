using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace WindowsFormsLinq
{
    public partial class Form2 : Form
    {
        NorthwindDataContext dc = new NorthwindDataContext();
        string kayitTipi = System.Configuration.ConfigurationManager.AppSettings["KayitTipi"];

        public Form2()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kayitTipi=="Linq")
            {

            }
            else
            {

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
