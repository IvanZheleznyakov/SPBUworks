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
        private bool isPressed = false;
        private bool isDrawing = false;
        private bool isMoved = false;
        private bool isDeleted = false;
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
            isPressed = true;
            X = e.X;
            Y = e.Y;

            if (isDrawing)
            {

            }
            else if (isDeleted)
            {

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (isPressed)
                {
                    X1 = e.X;
                    Y1 = e.Y;
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isPressed = false;
                twoPoint.Add(new TwoPoint(new Point(X, Y), new Point(X1, Y1)));
            }
            else if (isDeleted)
            {
                isPressed = false;
                Point curPoint = new Point(e.X, e.Y);
                foreach (var p in twoPoint)
                {
                    if (curPoint == p.X || curPoint == p.Y)
                    {
                        twoPoint.Remove(p);
                        pictureBox1.Invalidate();
                        return;
                    }
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);

            if (isDrawing)
            {
                e.Graphics.DrawLine(pen, new Point(X, Y), new Point(X1, Y1));
            }

            foreach (var p in twoPoint)
            {
                e.Graphics.DrawLine(pen, p.X, p.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender.Equals(button1))
            {
                isDrawing = true;
                isMoved = false;
                isDeleted = false;
                button1.BackColor = Color.Gray;
                button2.BackColor = SystemColors.Control;
                button3.BackColor = SystemColors.Control;
            }
            else if (sender.Equals(button2))
            {
                isDrawing = false;
                isMoved = true;
                isDeleted = false;
                button1.BackColor = SystemColors.Control;
                button2.BackColor = Color.Gray;
                button3.BackColor = SystemColors.Control;
            } 
            else if (sender.Equals(button3))
            {
                isDrawing = false;
                isMoved = false;
                isDeleted = true;
                button1.BackColor = SystemColors.Control;
                button2.BackColor = SystemColors.Control;
                button3.BackColor = Color.Gray;
            }
        }
    }
}
