using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("активы");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("абонент");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("оборудование");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("crm");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("события");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("отчёты");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("собрание");
        }
    }
}
