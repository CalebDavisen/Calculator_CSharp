/*
 * Calculator
 * Davidsen
 * 9/22/2023
 * DDA
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Davidsen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double num1, num2, product;
            num1 = Convert.ToDouble(firstNumberBox.Text);
            num2 = Convert.ToDouble(secondNumberBox.Text);
            product = num1 + num2;
            outputBox.Items.Add(num1 + " + " + num2 + " = " + product);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            double num1, num2, product;
            num1 = Convert.ToDouble(firstNumberBox.Text);
            num2 = Convert.ToDouble(secondNumberBox.Text);
            product = num1 - num2;
            outputBox.Items.Add(num1 + " - " + num2 + " = " + product);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double num1, num2, product;
            num1 = Convert.ToDouble(firstNumberBox.Text);
            num2 = Convert.ToDouble(secondNumberBox.Text);
            product = num1 * num2;
            outputBox.Items.Add(num1 + " * " + num2 + " = " + product);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double num1, num2, product;
            num1 = Convert.ToDouble(firstNumberBox.Text);
            num2 = Convert.ToDouble(secondNumberBox.Text);
            product = num1 / num2;
            outputBox.Items.Add(num1 + " / " + num2 + " = " + product);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputBox.Items.Clear();
        }
    }
}
