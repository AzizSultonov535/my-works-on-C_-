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
            public int limit = 0;
            private double timeOnRoad;
            private double fast;

            public double distanceTravel()
            {
                return timeOnRoad * fast;
                 
            }
            public string goToWhere(string A,string B)
            {
                return this.model + " " + this.number + " driving in " + A + " to " + B + "\n";
            }
            public string racing(int laps)
            {
                string msg = "";
                for (int i = 1; i <= laps;i++)
                {
                    msg += this.model + " " + this.number + " is racing " + i + " laps completed! \n";
                }
                return msg;
            }
            public void chekLimit(int laps)
            {
                this.limit = this.limit + laps;
                if (limit>=10)
                {
                    throw new Exception("Limiti moshin ado Moshina musorva parto!");
                }
            }
            public void goToOldLocation(string A)
            {
                MessageBox.Show(this.model + " " +this.number + " driving to "+ A);
            }
            public string myCar()
            {
                return this.number + " " + this.model + " " + this.brand + " " + this.color + "\n";
            }
            public Car(string number,string brand, string model, string color, double timeOnRoad, double fast)
            {
                this.number = number;
                this.brand = brand;
                this.model = model;
                this.color = color;
                this.timeOnRoad = timeOnRoad;
                this.fast = fast;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string carNumber = textBox1.Text;
            string carBrand = textBox2.Text;
            string carModel = textBox3.Text;
            string carColor = textBox4.Text;
            double timeOnRoad = Convert.ToDouble(textBox8.Text);
            double fast = Convert.ToDouble(textBox9.Text);
            myCar = new Car(carNumber, carBrand, carModel, carColor,timeOnRoad,fast);
            label10.Text = myCar.myCar()+"\n";
            label10.Text += myCar.distanceTravel();
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
            label10.Text += myCar.goToWhere(from, to);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int lap = Convert.ToInt32(textBox7.Text);

            label10.Text+=myCar.racing(lap);

            string from = textBox5.Text;
            //myCar.goToOldLocation(from);
            try
            {
                myCar.chekLimit(lap);
            }
            catch (Exception ex)
            {
                label10.Text+= ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Car myCar1 = new Car("A5835", "Kadet", "Opel", "White", 1.5 , 35.8);
            Car myCar2 = new Car("A7757", "M5", "BMW", "Black", 2.5, 110.5);
            Car myCar3 = new Car("C0023", "Хэтчбек", "Opel", "White", 3, 60.8);
            
          
            label10.Text += myCar1.myCar();
            label10.Text += myCar2.myCar();
            label10.Text += myCar3.myCar();

            if (myCar1.distanceTravel() > myCar2.distanceTravel())
            {
                if (myCar1.distanceTravel() > myCar3.distanceTravel())
                {
                    label10.Text += myCar1.myCar() + myCar1.distanceTravel()+"km MAKKSIMALNIY PUT";
                }
                else
                {
                    label10.Text += myCar3.myCar() + myCar3.distanceTravel() + "km MAKKSIMALNIY PUT";
                }
            }
            else
            {
                if (myCar1.distanceTravel() > myCar3.distanceTravel())
                {
                    label10.Text += myCar1.myCar() + myCar1.distanceTravel() + "km MAKKSIMALNIY PUT";
                }
                else if(myCar3.distanceTravel() > myCar2.distanceTravel())
                {
                    label10.Text += myCar3.myCar() + myCar3.distanceTravel() + "km MAKKSIMALNIY PUT";
                }
                else if (myCar3.distanceTravel() < myCar2.distanceTravel())
                {
                    label10.Text += myCar2.myCar() + myCar2.distanceTravel() + "km MAKKSIMALNIY PUT";
                }
                else
                {
                    label10.Text += myCar3.myCar() + myCar3.distanceTravel() + "km MAKKSIMALNIY PUT";
                }
            }
        }
    }
}
