using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labvp3
{
    public partial class Form1 : Form
    {
        
        static public List<Player> igraci = new List<Player>();
        public Player igrac;
        public Equation eq;
        public Form1()
        {
            InitializeComponent();
        }

        public void newRound() {
            eq = new Equation();
            tbOp1.Text = eq.broj1.ToString();
            tbOp2.Text = eq.broj2.ToString();
            tbOp.Text = eq.znak;
            tbRezultat.Clear();



        }
        public void newGame() {
            if (tbIgrac.Text != "")
            {
                igrac = new Player(tbIgrac.Text);
                igraci.Add(igrac);
                newRound();
                timer1.Start();
             
            }
           
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int rez = -1;
            int.TryParse(tbRezultat.Text, out rez);
            if (rez == eq.rezultat) {
                igrac.poeni++;
                progressBar1.Value = igrac.poeni;
                if (igrac.poeni > 0 && igrac.poeni % 10 == 0) {
                    igrac.vreme += 10;
                }
            }

            newRound();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
                igrac.vreme--;
            label2.Text = igrac.vreme.ToString();
                progressBar2.Value = igrac.vreme;
                if (igrac.vreme == 0)
                {
                   // MessageBox.Show("loser");
                    timer1.Stop();
                }
            
        }

        private void tbRezultat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13) {
                int rez = -1;
                int.TryParse(tbRezultat.Text, out rez);
                if (rez == eq.rezultat)
                {
                    igrac.poeni++;
                    label1.Text = igrac.poeni.ToString();
                    progressBar1.Value = igrac.poeni;
                    if (igrac.poeni > 0 && igrac.poeni % 10 == 0)
                    {
                        igrac.vreme += 10;
                    }
                }

                newRound();
            }
        }

        private void btnIgraci_Click(object sender, EventArgs e)
        {
            Form2 objekt = new Form2();
            objekt.Show();


        }

        private void btnCao_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
