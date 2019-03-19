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
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Neelumoil();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainpage_Load(object sender, EventArgs e)
        {
           // Loginscreen.Visible = false;
        }
    }
}
