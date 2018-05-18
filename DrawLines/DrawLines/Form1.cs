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

namespace DrawLines
{
    public partial class Form1 : Form
    {
        public LineDoc lineDoc;
        public static float lineTickness = 2;
        public Point mousePosition;
        public Stack<Line> undo;
        public string FileName;

        public Form1()
        {
            
            InitializeComponent();
            lineDoc = new LineDoc();
            undo = new Stack<Line>();
            this.DoubleBuffered = true;
            mousePosition = new Point(0,0);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            lineDoc.Draw(e.Graphics);


            Pen p = new Pen(Color.Red, 1);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            e.Graphics.DrawLine(p, new Point(mousePosition.X, 0), new Point(mousePosition.X, this.Height));
            e.Graphics.DrawLine(p, new Point(0, mousePosition.Y), new Point(this.Width, mousePosition.Y));


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (lineDoc.odKade.IsEmpty)
            {
                lineDoc.odKade = new Point(e.X, e.Y);
            }
            else {
                Point doKade = new Point(e.X, e.Y);
                Line newLine = new Line(lineDoc.odKade, doKade, lineTickness);
                lineDoc.addLine(newLine);
                //undo.Push(newLine);
                Invalidate(true);
                lineDoc.odKade = doKade;
                undo.Clear();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition.X = e.X;
            mousePosition.Y = e.Y;
            Invalidate(true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineDoc = new LineDoc();
            undo.Clear();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lineDoc.lines.Count == 0) return;
            undo.Push(lineDoc.lines.Last());
            lineDoc.lines.Remove(lineDoc.lines.Last());
            lineDoc.odKade = lineDoc.lines.Last().End;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undo.Count == 0) return; 
            lineDoc.lines.Add(undo.Pop());
            lineDoc.odKade = lineDoc.lines.Last().End;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save your file";
                sfd.Filter = "Lines document | *.ld";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileName = sfd.FileName;
                }
            }
            try {
                using (FileStream stream = new FileStream(FileName, FileMode.Create)) {
                    var formater = new BinaryFormatter();
                    formater.Serialize(stream, (LineDoc)lineDoc);
                    FileName = null;

                }
            } catch (Exception ex) {
                MessageBox.Show("error saving");
            }
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                OpenFileDialog sfd = new OpenFileDialog();
                sfd.Title = "Open your file";
                sfd.Filter = "Lines document | *.ld";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileName = sfd.FileName;
                }
            }
            try
            {
                using (FileStream stream = new FileStream(FileName, FileMode.Open))
                {
                    var formater = new BinaryFormatter();
                    lineDoc = (LineDoc)formater.Deserialize(stream);
                    FileName = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error saving");
            }
        }
    }
}
