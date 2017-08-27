using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_5
{
    public partial class MainForm : Form
    {
        bool hasDotDigit = false;
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            eqation.Text = "";
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            if ((resultTextBox.Text == "0") ||(operation_pressed))
                resultTextBox.Clear(); //開頭0或運算符號不做事,清除所有內容輸出。
            resultTextBox.Text = resultTextBox.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((resultTextBox.Text == "0") || (operation_pressed))
                resultTextBox.Clear();
            resultTextBox.Text = resultTextBox.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((resultTextBox.Text == "0") || (operation_pressed))
                resultTextBox.Clear();
            resultTextBox.Text = resultTextBox.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((resultTextBox.Text == "0") || (operation_pressed))
                resultTextBox.Clear();
            resultTextBox.Text = resultTextBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((resultTextBox.Text == "0") || (operation_pressed))
                resultTextBox.Clear();
            resultTextBox.Text = resultTextBox.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((resultTextBox.Text == "0") || (operation_pressed))
                resultTextBox.Clear();
            resultTextBox.Text = resultTextBox.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((resultTextBox.Text == "0") || (operation_pressed))
                resultTextBox.Clear();
            resultTextBox.Text = resultTextBox.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((resultTextBox.Text == "0") || (operation_pressed))
                resultTextBox.Clear();
            resultTextBox.Text = resultTextBox.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((resultTextBox.Text == "0") || (operation_pressed))
                resultTextBox.Clear();
            resultTextBox.Text = resultTextBox.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
           
            resultTextBox.Text = resultTextBox.Text + "0";
        }

        private void dotButton_Click_1(object sender, EventArgs e)
        {
            if (!hasDotDigit) {
                resultTextBox.Text = resultTextBox.Text + ".";
                hasDotDigit= true;
            }
            
        }


        private void operator_Click(object sender, EventArgs e)     //運算符號
        {
            Button b = (Button)sender;
            if (value!=0) {
                equalButton.PerformClick();                         //產生等於的運算
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else {
                operation = b.Text;
                value = double.Parse(resultTextBox.Text);           //數字存進value
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
        }

        private void equalButton_Click(object sender, EventArgs e)  //執行運算結果
        {
            switch (operation)
            {
                case "+":
                    resultTextBox.Text = (value + double.Parse(resultTextBox.Text)).ToString();
                    break;
                case "-":
                    resultTextBox.Text = (value - double.Parse(resultTextBox.Text)).ToString();
                    break;
                case "x":
                    resultTextBox.Text = (value * double.Parse(resultTextBox.Text)).ToString();
                    break;
                case "/":
                    resultTextBox.Text = (value / double.Parse(resultTextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = double.Parse(resultTextBox.Text);

        }


        private void CE_Click_1(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
        }
    }
}
