using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform_Calculator
{
    public partial class AddSubtractForm : Form
    {
        public AddSubtractForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //add first and second numbers together
            //display in result label

            double numberOne; //hold first number
            double numberTwo; //hold second number
            double total; //hold total of both numbers together

            double.TryParse(firstNumberTextBox.Text, out numberOne); //convert text to double
            double.TryParse(secondNumberTextBox.Text, out numberTwo); //convert text to double

            total = numberOne + numberTwo; //add both numbers together
            resultLabel.Text = total.ToString(); //return result
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            //subtract numbers
            //display in result label

            double numberOne; //hold first number
            double numberTwo; //hold second number
            double total; //hold total of numbers subtracted

            double.TryParse(firstNumberTextBox.Text, out numberOne); //convert text to double
            double.TryParse(secondNumberTextBox.Text, out numberTwo); //convert text to double

            total = numberOne - numberTwo; //subtract numbers
            resultLabel.Text = total.ToString(); //return result
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
