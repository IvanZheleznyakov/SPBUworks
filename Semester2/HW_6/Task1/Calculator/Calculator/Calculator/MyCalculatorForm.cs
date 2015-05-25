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
            if (this.OutputResult.Text[0] == '-')
            {
                this.OutputResult.Text = this.OutputResult.Text.Remove(0, 1);
                return;
            }
            this.OutputResult.Text = "-" + this.OutputResult.Text;
        }
    }
}
