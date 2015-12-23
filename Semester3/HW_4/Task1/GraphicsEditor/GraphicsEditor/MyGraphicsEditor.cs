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
        private bool isEndCatched = false;
        private float X = 0;
        private float Y = 0;
        private float X1 = 0;
        private float Y1 = 0;

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
            else if (isMoved)
            {
                float eps = 3F;
                foreach (var p in twoPoint)
                {
                    double length1 = Math.Sqrt(Math.Pow(X - p.X.X, 2) + Math.Pow(Y - p.X.Y, 2));
                    double length2 = Math.Sqrt(Math.Pow(X - p.Y.X, 2) + Math.Pow(Y - p.Y.Y, 2));
                    if (length1 < eps)
                    {
                        isEndCatched = true;
                        X = p.Y.X;
                        Y = p.Y.Y;
                        twoPoint.Remove(p);
                        return;
                    }
                    else if (length2 < eps)
                    {
                        isEndCatched = true;
                        X = p.X.X;
                        Y = p.X.Y;
                        twoPoint.Remove(p);
                        return;
                    }
                }
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
            else if (isMoved)
            {
                if (isPressed && isEndCatched)
                {
                    X1 = e.X;
                    Y1 = e.Y;
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing || (isMoved && isEndCatched))
            {
                isPressed = false;
                isEndCatched = false;
                PointF newP1 = new PointF(X, Y);
                PointF newP2 = new PointF(X1, Y1);
                TwoPoint newLine = new TwoPoint(newP1, newP2);
                twoPoint.Add(newLine);
            }
            else if (isDeleted)
            {
                const float eps = 0.25F;
                isPressed = false;
                foreach (var p in twoPoint)
                {
//                    int m = (p.X.Y - p.Y.Y) * curPoint.X + (p.Y.X - p.X.X) * curPoint.Y + (p.X.X * p.Y.Y - p.Y.X * p.X.Y);
//                    if (m == 0 && curPoint.X >= Math.Min(p.X.X, p.Y.X) && curPoint.X <= Math.Max(p.X.X, p.Y.X))
//                    if (Math.Abs(((Y - p.X.Y) / (p.Y.Y - p.X.Y)) - ((X - p.X.X) / (p.Y.X - p.X.X))) < eps)
                    double length1 = Math.Sqrt(Math.Pow(p.X.X - p.Y.X, 2) + Math.Pow(p.X.Y - p.Y.Y, 2));
                    double length2 = Math.Sqrt(Math.Pow(p.X.X - X, 2) + Math.Pow(p.X.Y - Y, 2));
                    double length3 = Math.Sqrt(Math.Pow(p.Y.X - X, 2) + Math.Pow(p.Y.Y - Y, 2));
                    if (Math.Abs(length1 - length2 - length3) < eps)
                    {
                        twoPoint.Remove(p);
                        pictureBox1.Invalidate();
                        return;
                    }
                }
            }
            else if (isMoved)
            {
                isPressed = false;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);

            if (isDrawing || (isMoved && isEndCatched))
            {
                e.Graphics.DrawLine(pen, new PointF(X, Y), new PointF(X1, Y1));
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
