using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string text;
        double number1;
        double number2;
        bool number1Set;
        bool number2Set;
        bool number1Point;
        bool number2Point;
        int numberOfPoints;
        string notation;
        bool notationClicked;
        bool newNumber;
        bool equalsPressed;

        public Form1()
        {
            text = "";
            notation = "";
            InitializeComponent();
            Clipboard.SetText("Hello, clipboard");
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b0_Click(object sender, EventArgs e)
        {
            numberPressed(0);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            numberPressed(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            numberPressed(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            numberPressed(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            numberPressed(4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            numberPressed(5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            numberPressed(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            numberPressed(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            numberPressed(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            numberPressed(9);
        }

        private void numberPressed(int number)
        {
            notationClicked = false;

            if (number1Point)
            {
                numberOfPoints++;
                if(numberOfPoints == 1)
                    text += ".";
                number1 = number1 + (number / (Math.Pow(10.0, numberOfPoints)));
            }
            else if(number2Point)
            {
                numberOfPoints++;
                if (numberOfPoints == 1)
                    text += ".";
                number2 = number2 + (number / (Math.Pow(10.0, numberOfPoints)));
            }
            else if (!number1Set)
            {
                if (equalsPressed)
                {
                    text = "";
                    number1 = number;
                    equalsPressed = false;
                }
                else
                    number1 = number1 * 10 + number;
            }
            else
            {
                number2 = number2 * 10 + number;
                number2Set = true;
            }
            newNumber = true;
            equalsPressed = false;


            text += number + "";
            textBox1.Text = text;
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            otherButtonClicked(" + ");
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            otherButtonClicked(" - ");
        }

        private void bmultiply_Click(object sender, EventArgs e)
        {
            otherButtonClicked(" x ");
        }

        private void bdivide_Click(object sender, EventArgs e)
        {
            otherButtonClicked(" / ");
        }

        private void otherButtonClicked(string n)
        {
            if(notationClicked)
            {
                text = textBox1.Text.Remove(textBox1.Text.Count()-3);
            }
            notationClicked = true;

            if (number2Set)
            {
                calculate();
            }

            number1Set = true;
            notation = n;
            text += notation;
            textBox1.Text = text;
            if (newNumber)
            {
                newNumber = false;
            }
            equalsPressed = false;
            // Reset . number counts
            number1Point = false;
            number2Point = false;
            numberOfPoints = 0;
        }

        private void bequals_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            double sum = 0;

            if (notation.Equals(" / "))
                sum = number1 / number2;
            else if (notation.Equals(" x "))
                sum = number1 * number2;
            else if (notation.Equals(" - "))
                sum = number1 - number2;
            else
                sum = number1 + number2;


            textBox1.Text = sum + "";

            // Reset, but keep using the sum if you're going to calculate more
            number1 = sum;
            number2 = 0;
            newNumber = true;
            number1Set = false;
            number2Set = false;
            equalsPressed = true;
            notationClicked = false;
            text = number1 + "";
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            bdotClicked();
        }

        private void bdotClicked()
        {
            textBox1.Text = textBox1.Text += ".";
            if (number2Set)
            {
                number2Point = true;
            }
            else
            {
                number1Point = true;
            }
        }

        private void Form1_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Multiply || (e.Shift && e.KeyCode == Keys.OemQuestion))
                otherButtonClicked(" x ");
            else if (e.KeyCode == Keys.Divide || (e.Shift && e.KeyCode == Keys.D7))
                otherButtonClicked(" / ");
            else if(e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
                otherButtonClicked(" + ");
            else if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
                otherButtonClicked(" - ");
            else if (e.KeyCode == Keys.OemPeriod)
                bdotClicked();
            else if (e.KeyCode == Keys.Enter)
                calculate();
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                numberPressed(0);
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                numberPressed(1);
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                numberPressed(2);
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                numberPressed(3);
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                numberPressed(4);
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                numberPressed(5);
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                numberPressed(6);
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                numberPressed(7);
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                numberPressed(8);
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                numberPressed(9);
        }

        private void sChanged(object sender, EventArgs e)
        {
            //textBox1.Width = (int)(this.Width - 130);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
