using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autentification
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Descriere Partid ---------------------------------------------------------------------------------",textBox1);

        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Descriere Partid ---------------------------------------------------------------------------------", textBox2);
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Descriere Partid ---------------------------------------------------------------------------------", textBox3);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }

            else if (!checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else if (!checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Please pick only one candidate!");
            }
            else if (!checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Please pick only one candidate!");
            }
            else if (checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Please pick only one candidate!");
            }
            else if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("Please pick only one candidate!");
            }
            else if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("Please pick a candidate!");
            }




        }
    }
}
