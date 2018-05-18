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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listBox1.DataSource = Form1.igraci.OrderByDescending(x => x.poeni).ToList();
                }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
