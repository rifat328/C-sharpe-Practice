using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.00;
        string input="";
        public calculator()
        {
            InitializeComponent();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            lblCalculatorDisplay.Text = "";
            input += "7";
            lblCalculatorDisplay.Text += input;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            lblCalculatorDisplay.Text = "";
            input += "8";
            lblCalculatorDisplay.Text += input;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            lblCalculatorDisplay.Text = "";
            input += "9";
            lblCalculatorDisplay.Text += input;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            lblCalculatorDisplay.Text = "";
            input += "4";
            lblCalculatorDisplay.Text += input;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lblCalculatorDisplay.Text = "";
            input += "5";
            lblCalculatorDisplay.Text += input;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lblCalculatorDisplay.Text = "";
            input += "6";
            lblCalculatorDisplay.Text += input;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            lblCalculatorDisplay.Text = "";
            input += "1";
            lblCalculatorDisplay.Text += input;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            lblCalculatorDisplay.Text = "";
            input += "2";
            lblCalculatorDisplay.Text += input;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lblCalculatorDisplay.Text = "";
            input += "3";
            lblCalculatorDisplay.Text += input;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            lblCalculatorDisplay.Text = "";
            input += "0";
            lblCalculatorDisplay.Text += input;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            
            result = 0.00;
             input = "";
            lblCalculatorDisplay.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e) //DOT decimal
        {
            lblCalculatorDisplay.Text = "";
            input += ".";
            lblCalculatorDisplay.Text += input;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            second = input;
            double firstNum;
            double secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            if (function=='+')// plus
            {
                result = firstNum + secondNum;
                lblCalculatorDisplay.Text = result.ToString();
            }
            else if (function=='-')//minus
            {
                result = firstNum - secondNum;
                lblCalculatorDisplay.Text = result.ToString();
            }
            else if (function=='/')//divide
            {
                if (secondNum == '0')
                {
                    lblCalculatorDisplay.Text = "Please No";

                }
                else 
                { 
                    result = firstNum / secondNum;
                    lblCalculatorDisplay.Text = result.ToString();
                }
            }
            else if (function == '*')//multiply
            {
                result = firstNum * secondNum;
                lblCalculatorDisplay.Text = result.ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            function = '+';
            lblCalculatorDisplay.Text += function;
            first = input;
            input = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            function = '-';
            lblCalculatorDisplay.Text += function;
            first = input;
            input = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            function = '*';
            lblCalculatorDisplay.Text += function;
            first = input;
            input = "";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            function = '/';
            lblCalculatorDisplay.Text += function;
            first = input;
            input = "";
        }
    }
}
