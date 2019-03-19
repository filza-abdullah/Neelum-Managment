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
    public partial class Neelumoil : Form
    {
        public Neelumoil()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Cost();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form f = new Inventory();
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Form f = new Customer();
                f.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                Form f = new Orders();
                f.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                Form f = new Sales();
                f.Show();
            }
        }

           
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void Neelumoil_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form f = new Receipt();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new Reports();
            f.Show();
        }
    }
}
