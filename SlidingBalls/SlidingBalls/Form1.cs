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

namespace SlidingBalls
{
    public partial class Form1 : Form
    {
        public BallDoc ballDoc { get; set; }
        public string FileName { get; set; }
        public static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            ballDoc = new BallDoc(this.Width, this.Height);
            timer1.Start();
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ballDoc.Draw(e.Graphics);
            toolStripStatusLabel1.Text = string.Format("Red balls: {0}", ballDoc.getRedBalls());

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Ball toAdd = new Ball(new Point(e.X, e.Y), Color.Red);
                ballDoc.AddBall(toAdd);
                Invalidate();
            }
            else if (e.Button == MouseButtons.Left) {

                ballDoc.checkRedClick(e.X, e.Y);

            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int sl = random.Next(0, 2);
                Color color;
                if (sl == 0) color = Color.Green; else color = Color.Blue;
                Ball toAdd = new Ball(new Point(e.X, e.Y), color);
                ballDoc.AddBall(toAdd);
                Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ballDoc.Move();
            Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null) {
                SaveFileDialog sfg = new SaveFileDialog();
                sfg.Title = "Save your game yes";
                sfg.Filter = "Sliding balls | *.sbg";
                
                if (sfg.ShowDialog() == DialogResult.OK) {
                    FileName = sfg.FileName;
                }
            }
            
            try
            {
                using (FileStream stream = new FileStream(FileName, FileMode.Create)) {
                    var formater = new BinaryFormatter();

                    formater.Serialize(stream,ballDoc);
                    FileName = null;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Something bad happened");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                OpenFileDialog sfg = new OpenFileDialog();
                sfg.Title = "Open your game yes";
                sfg.Filter = "Sliding balls | *.sbg";

                if (sfg.ShowDialog() == DialogResult.OK)
                {
                    FileName = sfg.FileName;
                }
            }

            try
            {
                using (FileStream stream = new FileStream(FileName, FileMode.Open))
                {
                    var formater = new BinaryFormatter();
                    ballDoc = (BallDoc)formater.Deserialize(stream);
                    FileName = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something bad happened");
            }
        }
    }
}
