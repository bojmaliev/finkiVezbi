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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dodadiAvtobus novAvtobus = new dodadiAvtobus();
            if (novAvtobus.ShowDialog() == DialogResult.OK) { 
                lbAvtobusi.Items.Add(novAvtobus.avtobus);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbAvtobusi.SelectedIndex != -1)
            {
                dodadiDestinacija novaDestinacija = new dodadiDestinacija();
                if (novaDestinacija.ShowDialog() == DialogResult.OK)
                {
                    lbDestinacii.Items.Add(novaDestinacija.destinacija);
                    Avtobus selektiran = (Avtobus)lbAvtobusi.SelectedItem;
                    selektiran.addDestinacija(novaDestinacija.destinacija);
                    loadDestinations();
                }
            }
            else {
                MessageBox.Show("Мора да имате изберено 1 автобус.");
            }
            
        }
        public void loadDestinations() {
            lbDestinacii.Items.Clear();
            tbProsecna.Clear();
            tbNajskapa.Clear();
            if (lbAvtobusi.SelectedIndex == -1) return;
            Avtobus selektiran = (Avtobus)lbAvtobusi.SelectedItem;
            if (selektiran.destinacii.Count() < 1) return;
            Destinacija najskapa = selektiran.destinacii[0];
            int prosek = 0;
            foreach (Destinacija dst in selektiran.destinacii) {
                lbDestinacii.Items.Add(dst);
                if (najskapa.cena < dst.cena) najskapa = dst;
                prosek += dst.cena;
            }
            prosek /= selektiran.destinacii.Count();
            tbNajskapa.Text = najskapa.ToString();
            tbProsecna.Text = prosek.ToString();
        }
        private void lbAvtobusi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAvtobusi.SelectedIndex != -1) {
                button3.Enabled = true;
                button2.Enabled = true;
                
            }
            loadDestinations();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да му го пушите на јанакИ? ", "Прашање", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                lbAvtobusi.Items.RemoveAt(lbAvtobusi.SelectedIndex);
                loadDestinations();
            }
        }
    }
}
