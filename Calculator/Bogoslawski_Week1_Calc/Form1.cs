using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bogoslawski_Week1_Calc
{
    public partial class Form1 : Form
    {
        ////Variables
        double num1, num2, rslt;
        string stroprnd;

        public Form1()
        {
            InitializeComponent();
        }

        ////The 1 button
        private void btn1_Click(object sender, EventArgs e)
        {
            txtLCD.Text = txtLCD.Text + "1";
            ////*txtLCDScreen.Text += "1";* (Shorter way)////
        }

        ////The 2 button
        private void btn2_Click(object sender, EventArgs e)
        {
            txtLCD.Text = txtLCD.Text + "2";
        }

        ////The 3 button
        private void btn3_Click(object sender, EventArgs e)
        {
            txtLCD.Text = txtLCD.Text + "3";
        }

        ////The 4 button
        private void btn4_Click(object sender, EventArgs e)
        {
            txtLCD.Text = txtLCD.Text + "4";
        }

        ////The 5 button
        private void btn5_Click(object sender, EventArgs e)
        {
            txtLCD.Text = txtLCD.Text + "5";
        }

        ////The 6 button
        private void btn6_Click(object sender, EventArgs e)
        {
            txtLCD.Text = txtLCD.Text + "6";
        }

        ////The 7 button
        private void btn7_Click(object sender, EventArgs e)
        {
            txtLCD.Text = txtLCD.Text + "7";
        }

        ////The 8 button
        private void btn8_Click(object sender, EventArgs e)
        {
            txtLCD.Text = txtLCD.Text + "8";
        }

        ////The 9 button
        private void btn9_Click(object sender, EventArgs e)
        {
            txtLCD.Text = txtLCD.Text + "9";
        }

        ////The 0 button
        private void btn0_Click(object sender, EventArgs e)
        {
            txtLCD.Text = txtLCD.Text + "0";
        }

        ////The decimal button
        private void Decimal_Click(object sender, EventArgs e)
        {
            txtLCD.Text = txtLCD.Text + ".";
        }

        ////The percent button////////////BROKEN///////////BROKEN//////////////////
        ////I can't seem to figure out the math to get this to work.///////////////
        ////I understand I am multiplying my second number by .01//////////////////
        ////but can not seem to get any kind of code to work.//////////////////////
        ///////////////////////////////////////////////////////////////////////////
        private void Percent_Click(object sender, EventArgs e)
        {

        }

        ////The addition button/////////////////////////////////////////////////////
        private void Addition_Click(object sender, EventArgs e)
        {
            //Gets the first number in equation
            num1 = double.Parse(txtLCD.Text);

            //Get the operand
            stroprnd = "+";

            //Used to add multiple numbers
            rslt = rslt + num1;

            //Clear screen
            txtLCD.Text ="";
        }


        ////The minus button////////////////////////////////////////////////////////
        private void Minus_Click(object sender, EventArgs e)
        {
            //Gets the first number in the equation
            num1 = double.Parse(txtLCD.Text);

            //Get the operand
            stroprnd = "-";

            //Used to subtract multiple numbers
            rslt = rslt - num1;

            //Clear screen
            txtLCD.Text = "";
        }


        ////The multiplication button///////////////////////////////////////////////
        private void Muliply_Click(object sender, EventArgs e)
        {
            //Gets the first number in equation
            num1 = double.Parse(txtLCD.Text);

            //Get the operand
            stroprnd = "*";

            //Used to multiply multiple numbers
            rslt = rslt * num1;

            //Clear screen
            txtLCD.Text = "";
        }


        ////The division button/////////////////////////////////////////////////////
        private void Division_Click(object sender, EventArgs e)
        {
            //Gets the first number in equation
            num1 = double.Parse(txtLCD.Text);

            //Get the operand
            stroprnd = "/";

            //Used to divide multiple numbers
            rslt = rslt / num1;

            //Clear screen
            txtLCD.Text = "";
        }


        ////The clear button///////////////////////////////////////////////////////
        private void clearbutton_Click(object sender, EventArgs e)
        {
            //Sets display to a blank screen
            txtLCD.Text = "";
            //Sets result to zero
            rslt = 0;
            //Sets number 1 to zero
            num1 = 0;
            //Sets number 2 to zero
            num2 = 0;
        }


        ////The equals button//////////////////////////////////////////////////////
        private void Result_Click(object sender, EventArgs e)
        {
            //Store the second number
            num2 = double.Parse(txtLCD.Text);

            //Performs addition and store result
            if (stroprnd == "+")
            {
                rslt = rslt + num2;
            }

            //Performs subtraction and store result
            if (stroprnd == "-")
            {
                rslt = num1 - num2;
            }

            //Performs multiplication and store result
            if (stroprnd == "*")
            {
                rslt = num1 * num2;
            }

            //Performs division and store result
            if (stroprnd == "/")
            {
                rslt = num1 / num2;
            }
            //Display results
            txtLCD.Text = rslt.ToString();
        
        }
    }
}


