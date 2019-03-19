using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhurshidSoapChemicalAndOilIndustry
{
    public partial class Neelum_soap : Form
    {
        public Neelum_soap()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Form f = new Customer_soap();
                f.Show();
            }
        }

        private void Neelum_soap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form f = new Inventory_soap();
                f.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new Receipt_soap();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Form f = new Sales_soap();
                f.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                Form f = new Orders_soap();
                f.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
               // Form f = new Expenditure_soap();
                //f.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form f = new Reports_soap();
            f.Show();
        }
    }
}
