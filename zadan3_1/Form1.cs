using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadan3_1
{
    public partial class Form1 : Form
    {
        static double f(double x1, double y1, double x2, double y2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 5);
        }
        static bool t(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, y1, x2, y2, x3, y3;
            x1 = double.Parse(numericUpDown1.Text);
            y1 = double.Parse(numericUpDown2.Text);
            x2 = double.Parse(numericUpDown3.Text);
            y2 = double.Parse(numericUpDown4.Text);
            x3 = double.Parse(numericUpDown5.Text);
            y3 = double.Parse(numericUpDown6.Text);

            double ab = f(x1, y1, x2, y2);
            double bc = f(x2, y2, x3, y3);
            double ac = f(x1, y1, x3, y3);

            textBox1.Text = ab.ToString();
            textBox2.Text = bc.ToString();
            textBox3.Text = ac.ToString();

            if (t(ab, bc, ac)) textBox4.Text = "Да";
            else textBox4.Text = "Нет";
        }
    }
}
