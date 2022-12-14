using System;
using System.Windows.Forms;
using System.Collections;

namespace stack_implementation
{
    public partial class Form1 : Form
    {

        Stack days = new Stack();


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            days.Push("Sunday");
            days.Push("Monday");
            days.Push("Tuesday");
            days.Push("Wednesday");
            days.Push("Thrusday");
            days.Push("Friday");
            days.Push("Saturday");

            foreach (String day in days)
                    listBox1.Items.Add(day);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            days.Push(textBox1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            days.Peek();        }
        private void button3_Click(object sender, EventArgs e)
        {
            days.Pop();        }
        private void button4_Click(object sender, EventArgs e)
        {
           MessageBox.Show(days.Count.ToString());
        }
        private void button6_Click(object sender, EventArgs e)
        {
            days.Clear();
        }

    }
}
