using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator_Plugin
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation = "";

        List<Plugin.Plugin> plugins = new List<Plugin.Plugin>();

        public Form1()
        {
            InitializeComponent();
            buttonSqr.Visible = false;
            buttonSqrt.Visible = false;
            txtBoxValue.Text = "0";
        }

        #region NUMBER_BUTTON_CLICK
        private void button0_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text = txtBoxValue.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text == "0" && txtBoxValue.Text != null)
            {
                txtBoxValue.Text = "1";
            }
            else
            {
                txtBoxValue.Text = txtBoxValue.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text == "0" && txtBoxValue.Text != null)
            {
                txtBoxValue.Text = "2";
            }
            else
            {
                txtBoxValue.Text = txtBoxValue.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text == "0" && txtBoxValue.Text != null)
            {
                txtBoxValue.Text = "3";
            }
            else
            {
                txtBoxValue.Text = txtBoxValue.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text == "0" && txtBoxValue.Text != null)
            {
                txtBoxValue.Text = "4";
            }
            else
            {
                txtBoxValue.Text = txtBoxValue.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text == "0" && txtBoxValue.Text != null)
            {
                txtBoxValue.Text = "5";
            }
            else
            {
                txtBoxValue.Text = txtBoxValue.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text == "0" && txtBoxValue.Text != null)
            {
                txtBoxValue.Text = "6";
            }
            else
            {
                txtBoxValue.Text = txtBoxValue.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text == "0" && txtBoxValue.Text != null)
            {
                txtBoxValue.Text = "7";
            }
            else
            {
                txtBoxValue.Text = txtBoxValue.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text == "0" && txtBoxValue.Text != null)
            {
                txtBoxValue.Text = "8";
            }
            else
            {
                txtBoxValue.Text = txtBoxValue.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text == "0" && txtBoxValue.Text != null)
            {
                txtBoxValue.Text = "9";
            }
            else
            {
                txtBoxValue.Text = txtBoxValue.Text + "9";
            }
        }

        #endregion

        #region OPERATOR_BUTTON_CLICK
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBoxValue.Text);
            txtBoxValue.Text = "0";
            Operation = "+";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBoxValue.Text);
            txtBoxValue.Text = "0";
            Operation = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBoxValue.Text);
            txtBoxValue.Text = "0";
            Operation = "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBoxValue.Text);
            txtBoxValue.Text = "0";
            Operation = "/";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text = "0";
        }

        private void buttonDots_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text = txtBoxValue.Text + ".";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;
            string strResult

            SecondNumber = Convert.ToDouble(txtBoxValue.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                txtBoxValue.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txtBoxValue.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txtBoxValue.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txtBoxValue.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txtBoxValue.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void buttonSqr_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtBoxValue.Text);
            double Result = plugins[0].sqrOperator(a);
            txtBoxValue.Text = Convert.ToString(Result);
            FirstNumber = Result;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtBoxValue.Text);
            double Result = plugins[0].sqrtOperator(a);
            txtBoxValue.Text = Convert.ToString(Result);
            FirstNumber = Result;
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text.Length > 1)
            {
                string newText = txtBoxValue.Text.Substring(0, txtBoxValue.Text.Length - 1);
                txtBoxValue.Text = newText;
            }
            else
            {
                txtBoxValue.Text = "0";
            }
        }
        #endregion


        private void checkBoxAdvance_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonSqr.Visible == false && buttonSqrt.Visible == false)
            {
                plugins.Add(new AdvancePlugIn());
                buttonSqr.Visible = true;
                buttonSqrt.Visible = true;
            }
            else
            {
                plugins.Clear();
                buttonSqr.Visible = false;
                buttonSqrt.Visible = false;
            }
        }
    }
}
