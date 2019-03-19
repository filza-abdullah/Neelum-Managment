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
    public partial class Cost_soap : Form
    {
        public Cost_soap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = comboBox1.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[n].Cells[2].Value = monthCalendar1.Text;
        }
    }
}
