using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Your_Calculator
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            display.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "9";
            display.Text += userInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "8";
            display.Text += userInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "7";
            display.Text += userInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            function = '-';
            first = userInput;
            userInput = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "4";
            display.Text += userInput;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "5";
            display.Text += userInput;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "6";
            display.Text += userInput;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "3";
            display.Text += userInput;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "2";
            display.Text += userInput;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "1";
            display.Text += userInput;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += ".";
            display.Text += userInput;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "0";
            display.Text += userInput;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            if (function == '+')
            {
                result = firstNum + secondNum;
                display.Text = result.ToString();
            }
            else if (function == '-')
            {
                result = firstNum - secondNum;
                display.Text = result.ToString();
            }
            else if (function == '*')
            {
                result = firstNum * secondNum;
                display.Text = result.ToString();
            }
            else if (function == '/')
            {
                if (secondNum == 0)
                {
                    display.Text = "Lol";
                }
                else
                {
                    result = firstNum / secondNum;
                    display.Text = result.ToString();
                }
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void display_Click(object sender, EventArgs e)
        {

        }
    }
}
