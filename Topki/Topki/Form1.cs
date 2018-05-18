using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topki
{
    public partial class Form1 : Form
    {
        private BallDoc ballDoc { get; set; }
        private int timerCall;
        private string FileName;
        private bool isPaused;
        public static Random r = new Random();
        public Form1()
        {
            timerCall = 0;
            ballDoc = new BallDoc(this.Width);
            InitializeComponent();
            FileName = null;
            if(isPaused == false)timer1.Start();
            this.DoubleBuffered = true;
            isPaused = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerCall % 10 == 0) {
                
                int randomY = r.Next(Ball.Radius * 2, this.Height - Ball.Radius * 2);
                Ball b = new Ball(new Point(-Ball.Radius, randomY));
                ballDoc.AddBall(b);
                
            }
            ballDoc.Move();
            Invalidate(true);
            timerCall++;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ballDoc.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ballDoc.checkHit(e.X, e.Y);
            Invalidate(true);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ballDoc.width = this.Width;
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Hits: {0}", ballDoc.Hits);
            toolStripStatusLabel2.Text = string.Format("Misses: {0}", ballDoc.Misses );
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Ball Flying docs | *.bfd";
                dialog.Title = "Open your flying doc";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = dialog.FileName;
                }
            }
            try
            {
                using (FileStream stream = new FileStream(FileName, FileMode.Open))
                {
                    var formater = new BinaryFormatter();
                    ballDoc = (BallDoc)formater.Deserialize(stream);
                    Invalidate(true);
                    FileName = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while trying to save your game");
            }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ballDoc = new BallDoc(this.Width);
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isPaused == false)
            {
                isPaused = true;
                pauseToolStripMenuItem.Text = "Continue";
                timer1.Stop();
            }
            else {
                isPaused = false;
                pauseToolStripMenuItem.Text= "Pause";
                timer1.Start();
            }
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null) {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Ball Flying docs | *.bfd";
                dialog.Title = "Save your flying doc";
                if (dialog.ShowDialog() == DialogResult.OK) {
                    FileName = dialog.FileName;
                }
            }
            try
            {
                using (FileStream stream = new FileStream(FileName, FileMode.Create)) {
                    var formater = new BinaryFormatter();
                    formater.Serialize(stream, (BallDoc)ballDoc);
                    FileName = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while trying to save your game");
            }

        }
    }
}
