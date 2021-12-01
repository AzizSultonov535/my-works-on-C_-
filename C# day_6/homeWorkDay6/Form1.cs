using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorkDay6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            try
            {
                label1.Text = Convert.ToString(ProizChicel(488557786, 576843));
            }
            catch (OverflowException ex)
            {
                label1.Text = "a 0 ba barobar shudanash mumkin nest";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }

                
            //label1.Text = Convert.ToString(ProizChicel(a, b));
        }
        static int ProizChicel(int a, int b)
        {
            switch (a)
            {
                case 0:
                    throw new Exception("a 0 ba barobar shudanash mumkin nest");
                default:
                    throw new FormatException("раками а слышком дароз шуда бурафт");
            }
            return a*b;
        }
    }
}
