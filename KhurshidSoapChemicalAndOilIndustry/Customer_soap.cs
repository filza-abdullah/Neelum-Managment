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
    public partial class Customer_soap : Form
    {
        public Customer_soap()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[n].Cells[3].Value = dateTimePicker1.Text;
            dataGridView1.Rows[n].Cells[4].Value = textBox5.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
