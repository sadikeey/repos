using System;
using System.Windows.Forms;

namespace comboBox_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("D");
            comboBox1.Items.Add("E");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(textBox1.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(int.Parse(textBox1.Text));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }
    }
}
