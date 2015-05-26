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
    public partial class MyCalculatorForm : Form
    {
        private Expression expression = new Expression();
        private bool lastClickOnOperation = false;

        public MyCalculatorForm()
        {
            InitializeComponent();
        }

        private void OnButtonClearClick(object sender, EventArgs e)
        {
            this.OutputResult.Text = "0";
            expression.Clear();
        }

        private void OnButtonChangeSignClick(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error" && !lastClickOnOperation)
            {
                if (this.OutputResult.Text[0] == '-')
                {
                    this.OutputResult.Text = this.OutputResult.Text.Remove(0, 1);
                    return;
                }
                this.OutputResult.Text = "-" + this.OutputResult.Text;
            }
        }

        private void OnButton0Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error" && !lastClickOnOperation)
            {
                this.OutputResult.Text += "0";
                return;
            }
            this.OutputResult.Text = "0";
            lastClickOnOperation = false;
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error" && !lastClickOnOperation)
            {
                this.OutputResult.Text += "1";
                return;
            }
            this.OutputResult.Text = "1";
            lastClickOnOperation = false;
        }

        private void OnButton2Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error" && !lastClickOnOperation)
            {
                this.OutputResult.Text += "2";
                return;
            }
            this.OutputResult.Text = "2";
            lastClickOnOperation = false;
        }

        private void OnButton3Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error" && !lastClickOnOperation)
            {
                this.OutputResult.Text += "3";
                return;
            }
            this.OutputResult.Text = "3";
            lastClickOnOperation = false;
        }

        private void OnButton4Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error" && !lastClickOnOperation)
            {
                this.OutputResult.Text += "4";
                return;
            }
            this.OutputResult.Text = "4";
            lastClickOnOperation = false;
        }

        private void OnButton5Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error" && !lastClickOnOperation)
            {
                this.OutputResult.Text += "5";
                return;
            }
            this.OutputResult.Text = "5";
            lastClickOnOperation = false;
        }

        private void OnButton6Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error" && !lastClickOnOperation)
            {
                this.OutputResult.Text += "6";
                return;
            }
            this.OutputResult.Text = "6";
            lastClickOnOperation = false;
        }

        private void OnButton7Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error" && !lastClickOnOperation)
            {
                this.OutputResult.Text += "7";
                return;
            }
            this.OutputResult.Text = "7";
            lastClickOnOperation = false;
        }

        private void OnButton8Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error" && !lastClickOnOperation)
            {
                this.OutputResult.Text += "8";
                return;
            }
            this.OutputResult.Text = "8";
            lastClickOnOperation = false;
        }

        private void OnButton9Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error" && !lastClickOnOperation)
            {
                this.OutputResult.Text += "9";
                return;
            }
            this.OutputResult.Text = "9";
            lastClickOnOperation = false;
        }

        private void OnButtonPointClick(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "Error" && (this.OutputResult.Text.IndexOf(',') == -1) && !lastClickOnOperation)
            {
                this.OutputResult.Text += ",";
            }
        }

        private void OnButtonPlusClick(object sender, EventArgs e)
        {
            expression.Add(this.OutputResult.Text);
            expression.Add('+');
//            this.OutputResult.Text = expression.Count();
            lastClickOnOperation = true;
        }

        private void OnButtonEqualClick(object sender, EventArgs e)
        {
            expression.Add(this.OutputResult.Text);
            this.OutputResult.Text = expression.Count();
            expression.Clear();
  //          expression.FirstNumber = this.OutputResult.Text;
  //          expression.SecondNumber = null;
            lastClickOnOperation = true;
        }

        private void OnButtonMinusClick(object sender, EventArgs e)
        {
            expression.Add(this.OutputResult.Text);
            expression.Add('-');
 //           this.OutputResult.Text = expression.Count();
            lastClickOnOperation = true;
        }

        private void OnButtonMultiplicationClick(object sender, EventArgs e)
        {
            expression.Add(this.OutputResult.Text);
            expression.Add('*');
  //          this.OutputResult.Text = expression.Count();
            lastClickOnOperation = true;
        }

        private void OnButtonDivisionClick(object sender, EventArgs e)
        {
            expression.Add(this.OutputResult.Text);
            expression.Add('/');
  //          this.OutputResult.Text = expression.Count();
            lastClickOnOperation = true;
        }

        private void OnButtonPercentClick(object sender, EventArgs e)
        {
            if (expression.FirstNumber == null)
            {
                expression.Add(this.OutputResult.Text);
            }
            expression.Add("0,01");
            expression.Add('*');
            this.OutputResult.Text = expression.Count();
            lastClickOnOperation = true;
        }

    }
}
