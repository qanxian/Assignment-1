using System;

namespace WinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            int num1 = Int32.Parse(str1);
            int num2 = Int32.Parse(str2);
            int res = 0;

            if (radioButton1.Checked == true)
            {
                res = num1 + num2;
            }
            else if (radioButton2.Checked == true)
            {
                res = num1 - num2;
            }
            else if (radioButton3.Checked == true) 
            {
                res = num1 * num2;
            }
            else if (radioButton4.Checked == true)
            {
                res = num1 / num2;
            }

            label3.Text = "The result of the calculation is: "+res.ToString(); 
        }
    }
}
