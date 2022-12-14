using System;
using System.Windows.Forms;

namespace calculator_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int sum = num + num2;
            textBox3.Text = sum.ToString();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int sub = num - num2;
            textBox3.Text = sub.ToString();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            double mul = num * num2;
            textBox3.Text = mul.ToString();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            float div = num / num2;
            textBox3.Text = div.ToString();
        }

    }
}
