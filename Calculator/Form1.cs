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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string prevEquation = "", prevOperation = "", operation = "";
        public static double answer = 0;

        private void Allbtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btn_Del":
                    if (TxtDisplay.Text.Length > 0)
                    {
                        TxtDisplay.Text = TxtDisplay.Text.Substring(0, TxtDisplay.Text.Length - 1);
                    }
                    break;
                case "btn_Clear":
                    operation = "";
                    TxtDisplay.ResetText();
                    TxtDisplay2.ResetText();
                    break;
                case "btn_ClearEntry":
                    TxtDisplay.ResetText();
                    break;
                case "btn_Decimal":
                    if (!TxtDisplay.Text.Contains(","))
                    {
                        TxtDisplay.Text += ",";
                    }
                    break;
                case "btn_PlusMinus":
                    if (TxtDisplay.Text.Length > 0)
                    {
                        if (!TxtDisplay.Text.Contains("-"))
                        {
                            TxtDisplay.Text = "-" + TxtDisplay.Text;
                        }
                        else if (TxtDisplay.Text.Contains("-"))
                        {
                            TxtDisplay.Text = TxtDisplay.Text.Substring(1, TxtDisplay.Text.Length - 1);
                        }
                    }
                    break;
                default:
                    if (operation == "=")
                    {
                        operation = "";
                        TxtDisplay.ResetText();
                    }

                    TxtDisplay.Text += btn.Text;

                    break;
            }
        }
        private void Operation_Click(object sender, EventArgs e)
        {
            Button opr = sender as Button;
            switch (opr.Text)
            {
                case "+":
                    if (TxtDisplay.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "+";
                            prevOperation = operation;
                            prevEquation = TxtDisplay.Text;
                            TxtDisplay2.Text = prevEquation + operation;
                            TxtDisplay.ResetText();
                        }
                    }
                    else
                    {
                        operation = "+";
                        multi_equations();
                    }
                    break;
                case "-":
                    if (TxtDisplay.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "-";
                            prevOperation = operation;
                            prevEquation = TxtDisplay.Text;
                            TxtDisplay2.Text = prevEquation + operation;
                            TxtDisplay.ResetText();
                        }
                    }
                    else
                    {
                        operation = "-";
                        multi_equations();
                    }
                    break;
                case "/":
                    if (TxtDisplay.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "/";
                            prevOperation = operation;
                            prevEquation = TxtDisplay.Text;
                            TxtDisplay2.Text = prevEquation + operation;
                            TxtDisplay.ResetText();
                        }
                    }
                    else
                    {
                        operation = "/";
                        multi_equations();
                    }
                    break;
                case "*":
                    if (TxtDisplay.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "*";
                            prevOperation = operation;
                            prevEquation = TxtDisplay.Text;
                            TxtDisplay2.Text = prevEquation + operation;
                            TxtDisplay.ResetText();
                        }
                    }
                    else
                    {
                        operation = "x";
                        multi_equations();
                    }
                    break;
                case "=":
                    if (TxtDisplay.Text.Length > 0)
                    {
                        operation = "=";
                        multi_equations();
                        TxtDisplay2.ResetText();
                        TxtDisplay.Text = answer.ToString();
                    }
                    break;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void multi_equations()
        {
            if (prevOperation == "+")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) + Convert.ToDouble(TxtDisplay.Text);

                prevEquation = answer.ToString();
                TxtDisplay2.Text = prevEquation + operation;
                TxtDisplay.ResetText();
            }
            if (prevOperation == "/")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) / Convert.ToDouble(TxtDisplay.Text);

                prevEquation = answer.ToString();
                TxtDisplay2.Text = prevEquation + operation;
                TxtDisplay.ResetText();
            }
            if (prevOperation == "*")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) * Convert.ToDouble(TxtDisplay.Text);

                prevEquation = answer.ToString();
                TxtDisplay2.Text = prevEquation + operation;
                TxtDisplay.ResetText();
            }
            if (prevOperation == "-")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) - Convert.ToDouble(TxtDisplay.Text);

                prevEquation = answer.ToString();
                TxtDisplay2.Text = prevEquation + operation;
                TxtDisplay.ResetText();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
