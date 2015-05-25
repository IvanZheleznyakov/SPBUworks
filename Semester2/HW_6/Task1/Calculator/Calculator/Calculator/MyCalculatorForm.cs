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
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error")
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
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error")
            {
                this.OutputResult.Text += "0";
                return;
            }
            this.OutputResult.Text = "0";
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error")
            {
                this.OutputResult.Text += "1";
                return;
            }
            this.OutputResult.Text = "1";
        }

        private void OnButton2Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error")
            {
                this.OutputResult.Text += "2";
                return;
            }
            this.OutputResult.Text = "2";
        }

        private void OnButton3Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error")
            {
                this.OutputResult.Text += "3";
                return;
            }
            this.OutputResult.Text = "3";
        }

        private void OnButton4Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error")
            {
                this.OutputResult.Text += "4";
                return;
            }
            this.OutputResult.Text = "4";
        }

        private void OnButton5Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error")
            {
                this.OutputResult.Text += "5";
                return;
            }
            this.OutputResult.Text = "5";
        }

        private void OnButton6Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error")
            {
                this.OutputResult.Text += "6";
                return;
            }
            this.OutputResult.Text = "6";
        }

        private void OnButton7Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error")
            {
                this.OutputResult.Text += "7";
                return;
            }
            this.OutputResult.Text = "7";
        }

        private void OnButton8Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error")
            {
                this.OutputResult.Text += "8";
                return;
            }
            this.OutputResult.Text = "8";
        }

        private void OnButton9Click(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error")
            {
                this.OutputResult.Text += "9";
                return;
            }
            this.OutputResult.Text = "9";
        }

    }
}
