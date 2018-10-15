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
        private bool startedTyping = false;
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
        int extraZeros = 0;
        private void displayNumber(Nullable<double> number)
        {
            string text = number.ToString();
            if (isFloat)
            {
                if (number == (int)number)
                    text = text + ".";
                for (int i = 1; i <= extraZeros; i++)
                    text = text + "0";
            }
            display.Text = text;
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            scapegoat.Select();
        }

        int pow = 10;
        const double UPPER_LIMIT_DECIMALS = 100000;

        private void modifyNumber(double val)
        {
            if (isFloat && val == 0)
                extraZeros++;
            else
                extraZeros = 0;

            startedTyping = true;
            output = null;

            if (!isFloat)
            {
                if (number * 10 <= UPPER_LIMIT_DECIMALS)
                {
                    number = number * 10 + sgn(number) * val;
                }
            }
            else
            {
                if (pow <= UPPER_LIMIT_DECIMALS)
                {

                    number = number + sgn(number) * val / pow;
                    pow = pow * 10;
                }
            }
            displayNumber(number);
        }
        private void enterNumber(object sender, EventArgs e)
        {
            Button clickedObj = (Button)sender;
            double val = Convert.ToInt32((string)clickedObj.Tag);
            modifyNumber(val);    
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            number = 0;
            output = 0;
            displayNumber(0);
        }

        private int sgn(Nullable<double> value)
        {
            if (value < 0)
                return -1;
            else
                return 1;
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
                    return (x * 100);
                default:
                    return null;
            }
        }

        private void signPress(object sender, EventArgs e)
        {
            int val = Convert.ToInt32((string)((Button)sender).Tag);
            pow = 10;
            //MessageBox.Show(startedTyping.ToString());
            if (startedTyping == true)
            {
                if (first_term == null)
                {
                    first_term = number;
                    displayNumber(0);
                    if (val == 5)
                    {
                        output = resolve(first_term, second_term, sign);
                        displayNumber(output);
                        number = 0;
                        first_term = null;
                        second_term = null;
                    }
                }
                else
                {
                    second_term = number;
                    output = resolve(first_term, second_term, sign);
                    displayNumber(output);
                    number = 0;
                    first_term = null;
                    second_term = null;
                    if (val != 0)
                    {
                        first_term = output;
                    }
                }
            }
            else
            {
                if (output != null)
                {
                    first_term = output;
                    output = null;
                }
            }
            label1.Text = first_term.ToString();
            label2.Text = second_term.ToString();
            label3.Text = output.ToString();
            number = 0;
            extraZeros = 0;
            isFloat = false;
            startedTyping = false;
            sign = val;
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (!startedTyping && output!= null)
            {
                startedTyping = true;
                number = output;   
            }
            number = -number;
            displayNumber(number);
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (!startedTyping && output != null)
            {
                startedTyping = true;
                number = output;
            }
            if (!isFloat)
            {
                isFloat = true;
                displayNumber(number);
            }
        }

        private void display_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                int val = (int)e.KeyCode-48;
                modifyNumber(val);
            }
        }
    }
}
