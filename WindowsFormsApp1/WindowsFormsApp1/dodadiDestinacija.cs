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
    public partial class dodadiDestinacija : Form
    {
        public Destinacija destinacija;
        public dodadiDestinacija()
        {
            InitializeComponent();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            if (tbDestinacija.Text != "") {
                destinacija = new Destinacija(tbDestinacija.Text, (int)numCas.Value, (int)numMin.Value, (int)numCena.Value);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
