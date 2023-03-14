using System;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = Convert.ToDecimal(txtNum1.Text);
                decimal num2 = Convert.ToDecimal(txtNum2.Text);
                char op = Convert.ToChar(txtOp.Text);
                decimal ans = 0;

                if (op == '+')
                {
                    ans = num1 + num2;
                }
                else if (op == '-')
                {
                    ans = num1 - num2;
                }
                else if (op == '*')
                {
                    ans = num1 * num2;
                }
                else if (op == '/')
                {
                    ans = num1 / num2;
                }
                else if (op == '^')
                {
                    ans = Convert.ToDecimal(Math.Pow((double)num1, (double)num2));
                }
                else if (op == '%')
                {
                    ans = (num1 / num2) * 100;
                }
                else { MessageBox.Show("Sorry, Invalid Operator"); }
                if (num1 == 0 && op == '/') { MessageBox.Show("0 cannot be a divisor or a dividend"); }
                if (num2 == 0 && op == '/') { MessageBox.Show("0 cannot be a divisor or a dividend"); }

                txtAns.Text = Convert.ToString(ans);
            }
            catch (Exception anything)
            {
                MessageBox.Show("Error: " + anything.Message);
            }

        }
    }
}
