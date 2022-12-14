using System;
using System.Windows.Forms;

namespace vowels_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String word = textBox1.Text;
            switch (word)
            {
                case "a":
                    MessageBox.Show("Vowel");
                    break;
                case "e":
                    MessageBox.Show("Vowel");
                    break;
                case "i":
                    MessageBox.Show("Vowel");
                    break;
                case "o":
                    MessageBox.Show("Vowel");
                    break;
                case "u":
                    MessageBox.Show("Vowel");
                    break;
                default:
                    MessageBox.Show("Consonet");
                    break;
            }
        }
    }
}
