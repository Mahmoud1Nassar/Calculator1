﻿using System;
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
    public partial class Form1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {

                TxtBox.Text = "0";
            }
            else { 
             TxtBox.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains(".")) {

                TxtBox.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {

                TxtBox.Text = "1";
            }

            else {
                TxtBox.Text += "1"; 
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {

                TxtBox.Text = "2";
            }

            else
            {
                TxtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {

                TxtBox.Text = "3";
            }

            else
            {
                TxtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {

                TxtBox.Text = "4";
            }

            else
            {
                TxtBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {

                TxtBox.Text = "5";
            }

            else
            {
                TxtBox.Text += "5";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {

                TxtBox.Text = "7";
            }

            else
            {
                TxtBox.Text += "7";
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            TxtBox.Text = "0";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "+";
        }

        private void DevideBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "/";
        }

        private void MinusPlusBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {

                TxtBox.Text = TxtBox.Text.Trim('-');

            }
            else { 
            
                    TxtBox.Text = "-" + TxtBox.Text;
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {

                TxtBox.Text = "6";
            }

            else
            {
                TxtBox.Text += "6";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {

                TxtBox.Text = "8";
            }

            else
            {
                TxtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {

                TxtBox.Text = "9";
            }

            else
            {
                TxtBox.Text += "9";
            }
        }

        private void MultiBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "*";
        }

        private void ModuleBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "%";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators) {

                case "-": valueSecond = decimal.Parse(TxtBox.Text);
                          Result = valueFirst - valueSecond;
                          TxtBox.Text = Result.ToString();
                          break;
                case "*":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst * valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "+":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst + valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "/":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst / valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "%":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst % valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;
            }
        }
    }
}
