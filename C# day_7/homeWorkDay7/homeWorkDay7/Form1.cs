using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorkDay7
{
    public partial class Form1 : Form
    {
        Car myCar;
        public Form1()
        {
            InitializeComponent();
        }
        
        public class Car
        {
            private string number;
            public string brand;
            public string model;
            public string color;
            public void goToWhere(string A,string B)
            {
                MessageBox.Show(this.model +" driving in "+A+" to "+ B);
            }
            public void racing(int laps)
            {
                for (int i = 1; i <= laps;i++ )
                {
                    MessageBox.Show(this.model+" " + i + " completed!");
                }
            }
            public void goToOldLocation(string A)
            {
                MessageBox.Show(this.brand + " in "+ A);
            }
            public Car(string number,string brand, string model, string color)
            {
                this.number = number;
                this.brand = brand;
                this.model = model;
                this.color = color;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string carNumber = textBox1.Text;
            string carBrand = textBox2.Text;
            string carModel = textBox3.Text;
            string carColor = textBox4.Text; 
            myCar = new Car(carNumber, carBrand, carModel, carColor);
            label8.Text = myCar.brand;
            label7.Text = myCar.model;
            label5.Text = myCar.color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string from = textBox5.Text;
            string to = textBox6.Text;
            myCar.goToWhere(from,to);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int lap = Convert.ToInt32(textBox7.Text);
            myCar.racing(lap);
        }
    }
}
