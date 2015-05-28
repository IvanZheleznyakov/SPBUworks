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

        private void OnButtonNumberClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (this.OutputResult.Text != "0" && this.OutputResult.Text != "Error" && !lastClickOnOperation)
            {
                this.OutputResult.Text += button.Text;
                return;
            }
            this.OutputResult.Text = button.Text;
            lastClickOnOperation = false;
        }

        private void OnButtonPointClick(object sender, EventArgs e)
        {
            if (this.OutputResult.Text != "Error" && (this.OutputResult.Text.IndexOf(',') == -1) && !lastClickOnOperation)
            {
                this.OutputResult.Text += ",";
            }
        }

        private void OnButtonOperationClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            expression.Add(this.OutputResult.Text);
            expression.Add(button.Text[0]);
            lastClickOnOperation = true;
        }

        private void OnButtonEqualClick(object sender, EventArgs e)
        {
            expression.Add(this.OutputResult.Text);
            this.OutputResult.Text = expression.Count();
            expression.Clear();
            lastClickOnOperation = true;
        }

        private void OnButtonPercentClick(object sender, EventArgs e)
        {
            if (expression.IsEmpty())
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
