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
        private List<Line> lines = new List<Line>();
        private bool isPressed = false;
        private bool isDrawing = false;
        private bool isMoving = false;
        private bool isDeleting = false;
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

            if (isMoving)
            {
                const float eps = 3F;
                foreach (var p in lines)
                {
                    double length1 = Math.Sqrt(Math.Pow(X - p.StartPoint.X, 2) + Math.Pow(Y - p.StartPoint.Y, 2));
                    double length2 = Math.Sqrt(Math.Pow(X - p.EndPoint.X, 2) + Math.Pow(Y - p.EndPoint.Y, 2));
                    if (length1 < eps)
                    {
                        isEndCatched = true;
                        X = p.EndPoint.X;
                        Y = p.EndPoint.Y;
                        lines.Remove(p);
                        return;
                    }
                    else if (length2 < eps)
                    {
                        isEndCatched = true;
                        X = p.StartPoint.X;
                        Y = p.StartPoint.Y;
                        lines.Remove(p);
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
            else if (isMoving)
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
            if (isDrawing || (isMoving && isEndCatched))
            {
                isPressed = false;
                isEndCatched = false;
                PointF newP1 = new PointF(X, Y);
                PointF newP2 = new PointF(X1, Y1);
                Line newLine = new Line(newP1, newP2);
                lines.Add(newLine);
            }
            else if (isDeleting)
            {
                const float eps = 0.25F;
                isPressed = false;
                foreach (var p in lines)
                {
                    double length1 = Math.Sqrt(Math.Pow(p.StartPoint.X - p.EndPoint.X, 2) + Math.Pow(p.StartPoint.Y - p.EndPoint.Y, 2));
                    double length2 = Math.Sqrt(Math.Pow(p.StartPoint.X - X, 2) + Math.Pow(p.StartPoint.Y - Y, 2));
                    double length3 = Math.Sqrt(Math.Pow(p.EndPoint.X - X, 2) + Math.Pow(p.EndPoint.Y - Y, 2));
                    if (Math.Abs(length1 - length2 - length3) < eps)
                    {
                        lines.Remove(p);
                        pictureBox1.Invalidate();
                        return;
                    }
                }
            }
            else if (isMoving)
            {
                isPressed = false;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);

            if (isDrawing || (isMoving && isEndCatched))
            {
                e.Graphics.DrawLine(pen, new PointF(X, Y), new PointF(X1, Y1));
            }

            foreach (var p in lines)
            {
                e.Graphics.DrawLine(pen, p.StartPoint, p.EndPoint);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender.Equals(drawButton))
            {
                isDrawing = true;
                isMoving = false;
                isDeleting = false;
                drawButton.BackColor = Color.Gray;
                moveButton.BackColor = SystemColors.Control;
                deleteButton.BackColor = SystemColors.Control;
            }
            else if (sender.Equals(moveButton))
            {
                isDrawing = false;
                isMoving = true;
                isDeleting = false;
                drawButton.BackColor = SystemColors.Control;
                moveButton.BackColor = Color.Gray;
                deleteButton.BackColor = SystemColors.Control;
            } 
            else if (sender.Equals(deleteButton))
            {
                isDrawing = false;
                isMoving = false;
                isDeleting = true;
                drawButton.BackColor = SystemColors.Control;
                moveButton.BackColor = SystemColors.Control;
                deleteButton.BackColor = Color.Gray;
            }
        }
    }
}
