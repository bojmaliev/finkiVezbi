using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingBalls
{
    public partial class Form1 : Form
    {
        public BallDoc ballDoc;
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
    }
}
