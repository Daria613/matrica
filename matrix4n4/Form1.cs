using System;
using System.Windows.Forms;

namespace matrix4na4
{
    public partial class Form1 : Form
    {
        double matrix4(double x1, double x2, double x3, double x4,
                      double y1, double y2, double y3, double y4,
                      double z1, double z2, double z3, double z4,
                      double t1, double t2, double t3, double t4)
        {
            double x = x1 * (y2 * (z3 * t4 - z4 * t3) - y3 * (z2 * t4 - z4 * t2) + y4 * (z2 * t3 - z3 * t2))
                      - x2 * (y1 * (z3 * t4 - z4 * t3) - y3 * (z1 * t4 - z4 * t1) + y4 * (z1 * t3 - z3 * t1))
                      + x3 * (y1 * (z2 * t4 - z4 * t2) - y2 * (z1 * t4 - z4 * t1) + y4 * (z1 * t2 - z2 * t1))
                      - x4 * (y1 * (z2 * t3 - z3 * t2) - y2 * (z1 * t3 - z3 * t1) + y3 * (z1 * t2 - z2 * t1));

            return x;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            double x3 = Convert.ToDouble(textBox3.Text);
            double x4 = Convert.ToDouble(textBox4.Text);
            double y1 = Convert.ToDouble(textBox5.Text); 
            double y2 = Convert.ToDouble(textBox6.Text); 
            double y3 = Convert.ToDouble(textBox7.Text); 
            double y4 = Convert.ToDouble(textBox8.Text); 
            double z1 = Convert.ToDouble(textBox9.Text); 
            double z2 = Convert.ToDouble(textBox10.Text); 
            double z3 = Convert.ToDouble(textBox11.Text); 
            double z4 = Convert.ToDouble(textBox12.Text); 
            double t1 = Convert.ToDouble(textBox13.Text); 
            double t2 = Convert.ToDouble(textBox14.Text); 
            double t3 = Convert.ToDouble(textBox15.Text); 
            double t4 = Convert.ToDouble(textBox16.Text);

            double a = matrix4(x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4, t1, t2, t3, t4);

            listBox1.Items.Add(a.ToString());
        }
    }
}
