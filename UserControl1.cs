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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            if (String.IsNullOrEmpty(textBox6.Text) && !String.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Please enter your password!");
            }

            if (!String.IsNullOrEmpty(textBox6.Text) && String.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Please enter your email!");
            }
            if (String.IsNullOrEmpty(textBox6.Text) && String.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Please enter your credentials!");
            }
            if (!String.IsNullOrEmpty(textBox9.Text) && !String.IsNullOrEmpty(textBox6.Text))
            {
                
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }

          
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
