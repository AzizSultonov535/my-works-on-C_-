using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorkDay2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xafta = int.Parse(textBox1.Text)*7;
            int mox = int.Parse(textBox2.Text)*30;
            int sol = int.Parse(textBox3.Text) * 365;
            int ruz = xafta + mox + sol;
            label4.Text = ruz + " руз";
        }
    }
}
