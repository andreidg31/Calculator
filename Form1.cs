using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private enum operators
        {
            EQUALS     = 0,
            PLUS       = 1,
            MINUS      = 2,
            MULTIPLY   = 3,
            DIVIDE     = 4,
            PERCENT    = 5,
            DECIMAL    = 6
        }

        private Nullable<double> first_term = null;
        private Nullable<double> second_term = null;
        private Nullable<double> output = null;
        private int sign = 0;
        private bool isFloat= false;
        private Nullable<double> number = 0;
       
        public Form1()
        {
            /*
             * Build a basic calculator app as the one in mobile and windows devices. 
             * Operations: 
             *  CE    = clear screen
             *  +    = addition
             *  -    = substraction
             *  *    = multiplication
             *  /    = division
             *  %    = percent
             *  +-   = change of sign
             *  .    = decimals
             *  =    = equal
             *  0-9  = numeric case
             *  
             * Ui layout:
             * 4 columns 
             * first row   -> display
             * second row  -> CE , / , * , -
             * third row   -> 7 , 8 , 9 , +
             * fourth row  -> 4 , 5 , 6 , +
             * fifth row   -> 1 , 2 , 3 , =
             * sixth row   -> % , 0 , . ,+-
             */

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display.ReadOnly = true;
            scapegoat.Hide();
            displayNumber(number);
        }

        private void displayNumber(Nullable<double> numb)
        {
            if (numb < 0)
                display.Text = (-1*numb).ToString() + "-";
            else
                display.Text = numb.ToString();
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            scapegoat.Select();
        }

        int pow = 10;
        const double UPPER_LIMIT_DECIMALS = 100000;
        private void enterNumber(object sender, EventArgs e)
        {
            Button clickedObj = (Button)sender;
            double val = Convert.ToInt32((string)clickedObj.Tag);
            //MessageBox.Show(sign.ToString());
            
            if (!isFloat){
                if (number * 10 <= UPPER_LIMIT_DECIMALS)
                {
                    number = number * 10 + val;
                }
            }
            else{
                if (pow <= UPPER_LIMIT_DECIMALS){

                    number = number + val / pow;
                    pow = pow * 10;
                }
            }
            displayNumber(number);
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            number = 0;
            output = 0;
            displayNumber(0);
        }

        private const int NEUTRAL_ADITION = 0;
        private const int NEUTRAL_MULTIPLICATION = 1;

        private Nullable<double> resolve(Nullable<double> x, Nullable<double> y,int sign)
        {
            
            switch ((operators)sign)
            {
                case operators.PLUS:
                    if (y == null)
                        y = NEUTRAL_ADITION;
                    return x + y;
                case operators.MINUS:
                    if (y == null)
                        y = NEUTRAL_ADITION;
                    return x - y;
                case operators.MULTIPLY:
                    if (y == null)
                        y = NEUTRAL_MULTIPLICATION;
                    return x * y;
                case operators.DIVIDE:
                    if (y == null)
                        y = NEUTRAL_MULTIPLICATION;
                    return x / y;
                case operators.PERCENT:
                    if (y == null)
                        y = NEUTRAL_MULTIPLICATION;
                    return (x / y * 100);
                default:
                    return null;
            }
        }

        private void signPress(object sender, EventArgs e)
        {
            int val = Convert.ToInt32((string)((Button)sender).Tag);
            
            if (first_term != null)
            {
                //MessageBox.Show(sign.ToString() + " " + val.ToString());
                if (sign != 0)
                { // if the last sign wasn't equals then we resolve the operators
                    second_term = number;
                    output = resolve(first_term, second_term, sign);
                    first_term = null;
                    second_term = null;
                    if (val != 0) // if the current sign isn't equals then we chain the operators
                    {
                        first_term = output;
                    }
                    displayNumber(output);
                }
                else
                {
                    //MessageBox.Show(output.ToString());
                    if (val != 0)
                    {
                        first_term = output;
                        second_term = null;
                    }
                }
                //MessageBox.Show(sign.ToString() + " " + val.ToString());
            }
            else
            {
                if (output == null)
                    first_term = number;
                else
                    first_term = output;
                
            }
            
            label1.Text = first_term.ToString();
            label2.Text = second_term.ToString();
            label3.Text = output.ToString();
            number = 0;
            sign = val;
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            number = -number;
            displayNumber(number);
        }
    }
}
