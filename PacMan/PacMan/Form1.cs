using PacMan.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*MARTIN BOJMALIEV 163099*/
namespace PacMan
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private PacMan pacman;
        private static readonly int TIMER_INTERVAL = 250;
        private static readonly int WORLD_WIDTH = 15;
        private static readonly int WORLD_HEIGHT = 10;
        private Image foodImage;
        private bool[,] foodWorld;
        public Form1()
        {

            InitializeComponent();
            foodImage = Resources.food;
            this.DoubleBuffered = true;
            newGame();
        }
        public void newGame()
        {
            pacman = new PacMan();
            this.Width = PacMan.Radius * 2 * (WORLD_WIDTH + 1);
            this.Height = PacMan.Radius * 2 * (WORLD_HEIGHT + 1);
            // овде кодот за иницијализација на матрицата foodWorld
            foodWorld = new bool[WORLD_HEIGHT,WORLD_WIDTH];
            for (int i = 0; i < WORLD_HEIGHT; i++) {
                for (int j = 0; j < WORLD_WIDTH; j++) {
                    foodWorld[i,j] = true;
                }
            }

            // овде кодот за иницијализација и стартување на тајмерот
            timer = new Timer();
            timer.Interval = TIMER_INTERVAL;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        public void timer_Tick(object sender, EventArgs e) {
            //ovde vasiot kod
            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
            foodWorld[pacman.Position.Y, pacman.Position.X] = false;
            Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) {
                pacman.ChangeDirection(DIRECTION.Up);
            }else if (e.KeyCode == Keys.Down)
            {
                pacman.ChangeDirection(DIRECTION.Down);
            }else if (e.KeyCode == Keys.Left)
            {
                pacman.ChangeDirection(DIRECTION.Left);
            }
            else if(e.KeyCode == Keys.Right) {
                pacman.ChangeDirection(DIRECTION.Right);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < WORLD_HEIGHT; i++)
            {
                for (int j = 0; j < WORLD_WIDTH; j++)
                {
                    if (foodWorld[i,j])
                    {
                        g.DrawImageUnscaled(foodImage, -10+j * PacMan.Radius * 2 + (PacMan.Radius * 2 - foodImage.Height) / 2, -5+i * PacMan.Radius * 2 + (PacMan.Radius * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
        }
    }
}
