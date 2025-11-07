using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix3na3
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

        double x;
        double y;
        double w;
        double z;



        double matrix3(double x1, double x2, double x3,
                       double y1, double y2, double y3,
                       double z1, double z2, double z3,
                       double w1, double w2, double w3)
        {
            double y = x1 * (w2 * z3 - w3 * z2) - w1 * (x2 * z3 - x3 * z2) + z1 * (x2 * w2 - x3 * w2);
            return y;

            double w = x1 * (y2 * z3 - y3 * z2) - y1 * (x2 * z3 - x3 * z2) + z1 * (x2 * y3 - x3 * y2);
            return w;

            double x = w1 * (y2 * z3 - y3 * z2) - y1 * (w2 * z3 - w3 * z2) + z1 * (w2 * y3 - w3 * y2);
            return x;

            double z = x1*(y2*w3 -y3*w2) - y1*(x2* w3 - x3*w2) + w1*(x2*y3 - x3*y2);
            return z;
        }


       


        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            double x3 = Convert.ToDouble(textBox3.Text);
            double y1 = Convert.ToDouble(textBox4.Text);
            double y2 = Convert.ToDouble(textBox5.Text);
            double y3 = Convert.ToDouble(textBox6.Text);
            double z1 = Convert.ToDouble(textBox7.Text);  
            double z2 = Convert.ToDouble(textBox8.Text);  
            double z3 = Convert.ToDouble(textBox9.Text);
            double w1 = Convert.ToDouble(textBox7.Text);
            double w2= Convert.ToDouble(textBox8.Text);
            double w3 = Convert.ToDouble(textBox9.Text);



            x = matrix3(x1,  x2,  x3, y1, y2,  y3,z1,  z2,  z3, w1,  w2, w3);
            y = matrix3(x1, x2, x3, y1, y2, y3, z1, z2, z3, w1, w2, w3);
            w = matrix3(x1, x2, x3, y1, y2, y3, z1, z2, z3, w1, w2, w3);
            z = matrix3(x1, x2, x3, y1, y2, y3, z1, z2, z3, w1, w2, w3);

            listBox1.Items.Add(x / w);

            listBox1.Items.Add(y / w);

            listBox1.Items.Add(z / w);
     

        }
    }
}
