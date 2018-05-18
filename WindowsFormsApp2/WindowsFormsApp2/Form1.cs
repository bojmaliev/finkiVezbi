using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "greska2");
                e.Cancel = true;
            }
            else {
                errorProvider1.SetError(textBox2, null);
            }
        }


        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "greska2");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show(errorProvider1.ToString());
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox3, null);
            }
        }
    }
}
