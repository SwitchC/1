using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        class Triangle
        {
            protected double a;// сторони трикутника 
            protected double b;// сторони трикутника
            protected double c;// сторони трикутника
            public void lineA(double a)
            {
                this.a = a;
            }
            public void lineB(double b)
            {
                this.b = b;
            }
            public void lineC(double c)
            {
                this.c = c;
            }
            public double perimeter()
            { return (c + a + b); }
            public double angleA_B()// метод визначає кут між стороню а та в 
            {
                return Math.Acos((a * a + b * b - c * c) / (2 * b * a));    
            }
            public double angleC_B()// метод визначає кут між  стороною с та в
            {
                return Math.Acos((b*b+c*c-a*a) / (2*b*c));
            }
            public double angleC_А()// метод визначає кут між  стороною с та а
            {
                return Math.Acos((a*a+c*c-b*b)/(2*a*c));
            }
        }
        class Triangle2:Triangle
        {
            private double area;
            public double Area
            {
                get
                {
                    return area;
                }
            }
            public void calculateArea()
            {

                if (a == b)
                {
                    this.area =  ((Math.Sqrt(b * b - ((c * c) / 4))) * (c))/2;
                }
                else if (a == c)
                {
                    this.area =((Math.Sqrt(c * c - ((b * b) / 4))) * (b))/2;
                }
                else if (b == c)
                {
                    this.area =((Math.Sqrt(c * c - ((a * a) / 4))) * (a))/2;
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(maskedTextBox2.Text);
                Convert.ToDouble(maskedTextBox1.Text);
                Convert.ToDouble(maskedTextBox3.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Сторони задаються лише цифрами");
                return;
            }
            double a = Convert.ToDouble(maskedTextBox2.Text);
            double b = Convert.ToDouble(maskedTextBox1.Text);
            double c = Convert.ToDouble(maskedTextBox3.Text);
            if ((a >= b + c) || (c >= a + b) || (b >= c + a))
            {
                MessageBox.Show("Трикутник не існує");
            }
            else
            {
                if ((a != b) && (a != c) && (b != c))
                {
                    Triangle ABC = new Triangle();
                    ABC.lineA(a);
                    ABC.lineB(b);
                    ABC.lineC(c);
                    label6.Text = Convert.ToString(ABC.angleA_B());
                    label8.Text = Convert.ToString(ABC.angleC_А());
                    label10.Text = Convert.ToString(ABC.angleC_B());
                    label12.Text = Convert.ToString(ABC.perimeter());
                    label13.Text = "";
                    label14.Text = "";
                }
                else
                {
                    Triangle2 ABC = new Triangle2();
                    ABC.lineA(a);
                    ABC.lineB(b);
                    ABC.lineC(c);
                    label6.Text = Convert.ToString(ABC.angleA_B());
                    label8.Text = Convert.ToString(ABC.angleC_А());
                    label10.Text = Convert.ToString(ABC.angleC_B());
                    label12.Text = Convert.ToString(ABC.perimeter());
                    label13.Text = "Площа";
                    ABC.calculateArea();
                    label14.Text= Convert.ToString(ABC.Area);
                }
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
