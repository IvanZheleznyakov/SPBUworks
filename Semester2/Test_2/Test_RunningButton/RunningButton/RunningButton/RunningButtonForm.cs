using System;
using System.Windows.Forms;

namespace RunningButton
{
    public partial class RunningButtonForm : Form
    {
        private Random randomNumber = new Random();

        public RunningButtonForm()
        {
            InitializeComponent();
        }

        private void MouseMoveOnRunningButton(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            //Random randomNumber = new Random();
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
