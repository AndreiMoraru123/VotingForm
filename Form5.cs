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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox9e.Text) && !String.IsNullOrEmpty(textBox6e.Text))
            {
                MessageBox.Show("Please enter your email!");
            }

            if (!String.IsNullOrEmpty(textBox9e.Text) && String.IsNullOrEmpty(textBox6e.Text))
            {
                MessageBox.Show("Please enter your new password!");
            }
            if (String.IsNullOrEmpty(textBox1e.Text) && String.IsNullOrEmpty(textBox9e.Text) && String.IsNullOrEmpty(textBox9e.Text))
            {
                MessageBox.Show("Please enter your new credentials!");
            }
            if (textBox1e.Text != textBox6e.Text)
            {
                MessageBox.Show("Passwords must match! ");
            }
            if (!String.IsNullOrEmpty(textBox1e.Text) && !String.IsNullOrEmpty(textBox6e.Text) && !String.IsNullOrEmpty(textBox9e.Text) && textBox1e.Text == textBox6e.Text)
            {

                this.Hide();
                Form1 forma11 = new Form1();
                forma11.ShowDialog();
            }
        }
    }
}
