using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    public enum DIRECTION {Up, Right, Down, Left};
    public class PacMan
    {
        public Point Position { get; set; }
        //gore 1, desno 2, dole 3, levo 4
        public DIRECTION Direction { get; set; }
        public static int Radius = 20;
        public int Speed { get; set; }
        public bool openMounth { get; set; }
        public static Brush brush = new SolidBrush(Color.Yellow);

        public PacMan() {
            Position = new Point(7,5);
            Speed = Radius;
            Direction = DIRECTION.Right;
            openMounth = false;
        }
        public void ChangeDirection(DIRECTION direction)
        {
            Direction = direction;
        }

        public void Move(int sizeX, int sizeY)
        {
            int newPos = 0;
            if (Direction == DIRECTION.Right)
            {
                if (Position.X == sizeX-1) newPos = 0;
                else newPos = Position.X + 1;
                Position = new Point(newPos, Position.Y);
            }
            else if (Direction == DIRECTION.Left)
            {
                if (Position.X == 0) newPos = sizeX-1;
                else newPos = Position.X - 1;
                Position = new Point(newPos, Position.Y);
            }
            else if (Direction == DIRECTION.Up)
            {
                if (Position.Y == 0) newPos = sizeY-1;
                else newPos = Position.Y - 1;
                Position = new Point(Position.X, newPos);
            }
            else if (Direction == DIRECTION.Down) {
                if (Position.Y == sizeY-1) newPos = 0;
                else newPos = Position.Y + 1;
                Position = new Point(Position.X, newPos);
            }
            if (openMounth) openMounth = false; else openMounth = true;
        }
        public void Draw(Graphics g)
        {
            if (openMounth == false)
                g.FillEllipse(brush, Position.X * Radius * 2, Position.Y * Radius * 2, Radius * 2, Radius * 2);
            else
            {
                int angle1=80, angle2=100;
                if (Direction == DIRECTION.Right) {
                    angle1 = 30; angle2 = 300;
                }else if (Direction == DIRECTION.Left) {
                    angle1 = 210; angle2 = 300;
                }
                else if (Direction == DIRECTION.Down)
                {
                    angle1 = 120; angle2 = 300;
                }
                else if (Direction == DIRECTION.Up)
                {
                    angle1 = 300; angle2 = 300;
                }
                g.FillPie(brush, Position.X * Radius * 2, Position.Y * Radius * 2, Radius * 2, Radius * 2, angle1, angle2);
            }
        }
    }

}
