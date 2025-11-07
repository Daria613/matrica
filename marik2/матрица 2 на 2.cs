using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double x;
        double y;
        double w;

        double matrix2x(double op1, double op2, double op3, double op4, double op6, double op5)
        {
           x = op3 * op5 - op6 * op2;
         


            return x;
        }

        double matrix2y(double op1, double op2, double op3, double op4, double op6, double op5)
        {
            
            y = op1 * op6 - op4 * op3;
           


            return y;
        }

        double matrix2w(double op1, double op2, double op3, double op4, double op6, double op5)
        {
           
            w = op1 * op5 - op4 * op2;


            return w;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double op1 = Convert.ToDouble(textBox1.Text);
            double op2 = Convert.ToDouble(textBox2.Text);
            double op3 = Convert.ToDouble(textBox3.Text);
            double op4 = Convert.ToDouble(textBox4.Text);
            double op5 = Convert.ToDouble(textBox5.Text);
            double op6 = Convert.ToDouble(textBox6.Text);

            x = matrix2x(op3, op5, op6, op2, op1, op4);
            y = matrix2y(op3, op5, op6, op2, op1, op4);
            w = matrix2w(op3, op5, op6, op2, op1, op4);

            listBox1.Items.Add(x / w);

            listBox2.Items.Add(y / w);

        }
    }
}
