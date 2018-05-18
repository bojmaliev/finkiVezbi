using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3VP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void CalculateTotal()
        {
            int vkupno = 0;
            int c = 0;
            if (rbMala.Checked)
            {
                int.TryParse(tbPica1.Text, out c);
            }
            else if (rbSredna.Checked)
            {
                int.TryParse(tbPica2.Text, out c);
            }
            else if (rbGolema.Checked) {
                int.TryParse(tbPica3.Text, out c);
            }
            vkupno += c;
            int d1 = 0; int d2 = 0; int d3 = 0;
            if (cbD1.Checked) {
                int.TryParse(tbDodatok1.Text, out d1);
            }
            if (cbD2.Checked)
            {
                int.TryParse(tbDodatok2.Text, out d2);
            }
            if (cbD3.Checked)
            {
                int.TryParse(tbDodatok3.Text, out d3);
            }
            vkupno += d1+d2+d3;

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int.TryParse(tbPijalok1vkupno.Text, out p1);
            int.TryParse(tbPijalok2vkupno.Text, out p2);
            int.TryParse(tbPijalok3vkupno.Text, out p3);
            vkupno += p1 + p2 + p3;

            int cenDes = 0;
            int.TryParse(tbCenaDesert.Text, out cenDes);
            vkupno += cenDes;

            tbVkupno.Text = vkupno.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни дека сакате да ја откажете нарачката?", "Дали сте сигурни", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Application.Exit();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cen = 0;
            if (listBox1.SelectedIndex == 0)
            {
                cen = 100;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                cen = 200;
            }
            else if (listBox1.SelectedIndex == 2) {
                cen = 300;
            }
            tbCenaDesert.Text = cen.ToString();
        }

        private void tbCenaDesert_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void tbPijalok1kol_TextChanged(object sender, EventArgs e)
        {
            int kol = 0;int cen = 0;
            int.TryParse(tbPijalok1kol.Text, out kol);
            int.TryParse(tbPijalok1cen.Text, out cen);
            tbPijalok1vkupno.Text = (kol * cen).ToString();
        }

        private void tbPijalok2kol_TextChanged(object sender, EventArgs e)
        {
            int kol = 0; int cen = 0;
            int.TryParse(tbPijalok2kol.Text, out kol);
            int.TryParse(tbPijalok2cen.Text, out cen);
            tbPijalok2vkupno.Text = (kol * cen).ToString();
        }

        private void tbPijalok3kol_TextChanged(object sender, EventArgs e)
        {
            int kol = 0; int cen = 0;
            int.TryParse(tbPijalok3kol.Text, out kol);
            int.TryParse(tbPijalok3cen.Text, out cen);
            tbPijalok3vkupno.Text = (kol * cen).ToString();
        }

        private void tbPijalok1cen_TextChanged(object sender, EventArgs e)
        {
            int kol = 0; int cen = 0;
            int.TryParse(tbPijalok1kol.Text, out kol);
            int.TryParse(tbPijalok1cen.Text, out cen);
            tbPijalok1vkupno.Text = (kol * cen).ToString();
        }

        private void tbPijalok2cen_TextChanged(object sender, EventArgs e)
        {
            int kol = 0; int cen = 0;
            int.TryParse(tbPijalok2kol.Text, out kol);
            int.TryParse(tbPijalok2cen.Text, out cen);
            tbPijalok2vkupno.Text = (kol * cen).ToString();
        }

        private void tbPijalok3cen_TextChanged(object sender, EventArgs e)
        {
            int kol = 0; int cen = 0;
            int.TryParse(tbPijalok3kol.Text, out kol);
            int.TryParse(tbPijalok3cen.Text, out cen);
            tbPijalok3vkupno.Text = (kol * cen).ToString();
        }

        private void tbPijalok1vkupno_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void tbPijalok2vkupno_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void tbPijalok3vkupno_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void tbPica1_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void tbPica2_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void tbPica3_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void tbDodatok1_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void tbDodatok2_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void tbDodatok3_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void tbNaplateno_TextChanged(object sender, EventArgs e)
        {
            int naplateno = 0;
            int.TryParse(tbNaplateno.Text, out naplateno);
            int vkupno= 0;
            int.TryParse(tbVkupno.Text, out vkupno);

            int vrakanje = vkupno - naplateno;
            if (vrakanje < 0) vrakanje = 0;
            tbVrakanje.Text = vrakanje.ToString();
        }
    }
}
