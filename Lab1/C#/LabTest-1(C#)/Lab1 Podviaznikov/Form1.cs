using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Podviaznikov
{
    public partial class Form1 : Form
    {
        SolveClass var1 = new SolveClass();
        int number;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                number = int.Parse(textBox1.Text);
                var1.isPerfect(number);
                var1.Solver();
                if (number <= 3000 && number > 0)
                {
                    if (var1.isPerfect(number) == true)
                    {
                        textBox2.Text = "This is a perfect number";
                    }
                    else
                    {
                        textBox2.Text = "This is`t a perfect number";
                    }
                }
                else
                    textBox1.Text = "Number must be less than 3000 and bigger then 0";
            }
            catch (Exception ex)
            {
                textBox1.Text = "You must input a natural number";
                textBox2.Text = "You must input a natural number";
            }
        }
    }
}
