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
    public partial class Loginscreen : Form
    {
        public Loginscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="filza" && textBox2.Text == "mirha")
            {
                mainpage mainP = new mainpage();
                mainP.ShowDialog();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Enter correct login!");
            }
            
        }

        private void Loginscreen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
