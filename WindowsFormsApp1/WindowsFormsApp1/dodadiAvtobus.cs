using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class dodadiAvtobus : Form
    {
        public Avtobus avtobus;
        public dodadiAvtobus()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            if (tbIme.Text != "" && tbRegistracija.Text != "")
            {
                avtobus = new Avtobus(tbIme.Text, tbRegistracija.Text, cbLokalen.Checked);
                DialogResult = DialogResult.OK;
            }
            else {
                MessageBox.Show("Сите полиња се задолжителни!");
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text.Length > 10)
            {
                errorProvider1.SetError(tbIme, null);
                e.Cancel = false;
            }
            else {
                errorProvider1.SetError(tbIme, "Mora da imate poveke od 10 karakteri");
                e.Cancel = true;
            }
        }

        private void tbRegistracija_Validating(object sender, CancelEventArgs e)
        {
            if (tbRegistracija.Text.Length > 4)
            {
                errorProvider1.SetError(tbRegistracija, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(tbRegistracija, "Mora da imate poveke od 4 karakteri");
                e.Cancel = true; ;
            }
        }
    }
}
