using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningButton
{
    public partial class RunningButtonForm : Form
    {
        public RunningButtonForm()
        {
            InitializeComponent();
        }

        private void MouseMoveOnRunningButton(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            var randomNumber = new Random();
            int newX = randomNumber.Next(0, this.ClientSize.Width - button.Width);
            int newY = randomNumber.Next(0, this.ClientSize.Height - button.Height);
            button.Location = new System.Drawing.Point(newX, newY);
        }

        private void OnRunningButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("YOU SHALL NOT PASS THE EXAM ):");
        }
    }
}
