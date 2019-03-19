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
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Neelumoil();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Neelum_soap();
            f.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
