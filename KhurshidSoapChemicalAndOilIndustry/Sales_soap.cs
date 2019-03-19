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
    public partial class Sales_soap : Form
    {
        public Sales_soap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView2.Rows.Add();
            dataGridView2.Rows[n].Cells[0].Value = textBox1.Text;
            dataGridView2.Rows[n].Cells[1].Value = dateTimePicker1.Text;
            dataGridView2.Rows[n].Cells[2].Value = textBox2.Text;
            dataGridView2.Rows[n].Cells[3].Value = textBox3.Text;
            dataGridView2.Rows[n].Cells[4].Value = textBox4.Text;
            dataGridView2.Rows[n].Cells[5].Value = textBox5.Text;
            dataGridView2.Rows[n].Cells[6].Value = textBox6.Text;
        }
    }
}
