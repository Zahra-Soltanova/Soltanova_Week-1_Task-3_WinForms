using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadan3_2
{
    public partial class Form1 : Form
    {
        static double f(double x)
        {
            double y;
            if (Math.Abs(x) < 2)
                y = Math.Sqrt(5 * Math.Pow(x, 2) + 5);
            else if (Math.Abs(x) >= 10)
                y = 0;
            else
                y = (Math.Abs(x)) / (Math.Sqrt(5 * Math.Pow(x, 2) + 5));

            return y;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown3.Value <= 0 || numericUpDown2.Value < numericUpDown1.Value) MessageBox.Show("Некорректный ввод данных");
            else
            {
                double a = double.Parse(numericUpDown1.Text);
                double b = double.Parse(numericUpDown2.Text);
                double h = double.Parse(numericUpDown3.Text);
                richTextBox1.Text = "Диапазон чисел от" + a + " до " + b + " с шагом " + h + "\n";
                for (double i = a; i <= b; i += h)
                    richTextBox1.Text += ("f(" + i + ") = " + f(i) + "\n");
            }
        }
    }
}
