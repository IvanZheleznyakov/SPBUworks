using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    public partial class MyGraphicsEditor : Form
    {
        private List<TwoPoint> twoPoint = new List<TwoPoint>();
        private bool isClicked = false;
        private int X = 0;
        private int Y = 0;
        private int X1 = 0;
        private int Y1 = 0;
        public MyGraphicsEditor()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            X = e.X;
            Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                X1 = e.X;
                Y1 = e.Y;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            twoPoint.Add(new TwoPoint(new Point(X, Y), new Point(X1, Y1)));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);

            e.Graphics.DrawLine(pen, new Point(X, Y), new Point(X1, Y1));
            foreach (var p in twoPoint)
            {
                e.Graphics.DrawLine(pen, p.X, p.Y);
            }
        }
    }
}
