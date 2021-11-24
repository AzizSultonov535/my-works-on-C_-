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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soat = int.Parse(textBox1.Text) / 3600;
            int daqiqa = (int.Parse(textBox1.Text)-(soat*3600))/60;
            int soniya = int.Parse(textBox1.Text) - soat * 3600 - daqiqa * 60;
            label2.Text = soat+":"+daqiqa+":"+soniya;
        }
    }
}
