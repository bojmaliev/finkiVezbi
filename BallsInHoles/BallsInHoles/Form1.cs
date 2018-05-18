using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsInHoles
{
    public partial class Form1 : Form
    {
        ballsHolesDoc doc;
        public Form1()
        {
            InitializeComponent();
            doc = new ballsHolesDoc(this.Width, this.Height);
            this.DoubleBuffered = true;
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            doc.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            doc.addBall(new Ball(new Point(e.X, e.Y), Color.Red));
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            doc.Move();
            Invalidate();
        }
    }
}
