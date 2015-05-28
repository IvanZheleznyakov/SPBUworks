using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockForm
{
    public partial class MyClock : Form
    {
        public MyClock()
        {
            InitializeComponent();
        }

        private void AddDigit(ref string number)
        {
            if (number.Length == 1)
            {
                number = "0" + number;
            }
        }

        private void ShowTime(object sender, EventArgs e)
        {
            var currentTime = DateTime.Now;
            string hours = Convert.ToString(currentTime.Hour);
            string minutes = Convert.ToString(currentTime.Minute);
            string seconds = Convert.ToString(currentTime.Second);

            this.AddDigit(ref hours);
            this.AddDigit(ref minutes);
            this.AddDigit(ref seconds);

            this.hoursTextBox.Text = hours;
            this.minutesTextBox.Text = minutes;
            this.secondsTextBox.Text = seconds;
        }
    }
}
