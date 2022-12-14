using System;
using System.Windows.Forms;

namespace student_mark_list_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float engInt = float.Parse(textBox1.Text);
            float engExt = float.Parse(textBox2.Text);
            float hindiInt = float.Parse(textBox3.Text);
            float hindiExt = float.Parse(textBox4.Text);
            float mathInt = float.Parse(textBox5.Text);
            float mathExt = float.Parse(textBox6.Text);
            float phyInt = float.Parse(textBox7.Text);
            float phyExt = float.Parse(textBox8.Text);

            float engTotal = engInt + engExt;
            float hindiTotal = hindiInt + hindiExt;
            float mathTotal = mathInt + mathExt;
            float phyTotal = phyInt + phyExt;

            textBox9.Text = engTotal.ToString();
            textBox10.Text = hindiTotal.ToString();
            textBox11.Text = mathTotal.ToString();
            textBox12.Text = phyTotal.ToString();

            // Display Total Marks Obtained
            float totalMarksObtainted = engTotal + hindiTotal + mathTotal + phyTotal;
            textBox15.Text = totalMarksObtainted.ToString();

            // Display percentage
            float per = (totalMarksObtainted / 400) * 100;
            textBox13.Text = per.ToString();

            String grade = "";

            if (per > 90)
                grade = "A";
            else if (per > 80 && per < 90)
                grade = "B";
            else if (per > 70 && per < 80)
                grade = "C";
            else if (per > 60 && per < 70)
                grade = "D";
            else if (per > 50 && per < 60)
                grade = "E";
            else if (per < 50)
                grade = "F";

            // Displaying the grade
            textBox14.Text = grade;

            // Giving a message whether student has passed or failed.

            String result = "";

            if (grade == "F")
                result = "Fail";
            else
                result = "Pass";
                
            // Display the message
            MessageBox.Show(result);
        }
    }
}
