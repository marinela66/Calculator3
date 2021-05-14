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
        double resultValue=0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonn_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text=="0") ||(isOperationPerformed))
            
                textBox_Result.Clear();
            isOperationPerformed = false;
            
            Button buttonn = (Button)sender;
           
            textBox_Result.Text = textBox_Result.Text + buttonn.Text;
        }

        private void textBox_Result_Click(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button buttonn = (Button)sender;
            operationPerformed = buttonn.Text;
            resultValue = double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void buttonn4_click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";

        }

        private void buttonn5_click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void buttonn15_click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;

            }
           // resultValue = double.Parse(textBox_Result.Text);
           // labelCurrentOperation.Text = "";
        }
    }
}
