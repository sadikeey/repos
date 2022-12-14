using System;
using System.Windows.Forms;

namespace simple_compound_interest_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int si = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text) * int.Parse(textBox3.Text)) / 100;

            int totalValue = si + int.Parse(textBox1.Text);

            textBox4.Text = si.ToString();
            textBox5.Text = totalValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float p = float.Parse(textBox6.Text); 
            float r = float.Parse(textBox7.Text);
            float t = float.Parse(textBox8.Text);

            double a = p * Math.Pow((1+r/100), t);

            double ci = a - p;

            textBox10.Text = ci.ToString();
            textBox11.Text = a.ToString();
        }
    }
}
