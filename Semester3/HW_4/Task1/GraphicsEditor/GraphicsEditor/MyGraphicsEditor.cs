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

        private void MouseDownOnPictureBox(object sender, MouseEventArgs e)
        {
            isPressed = true;
            X = e.X;
            Y = e.Y;

            if (isMoving)
            {
                const float eps = 3F;
                foreach (var line in lines)
                {
                    double length1 = Math.Sqrt(Math.Pow(X - line.StartPoint.X, 2) + Math.Pow(Y - line.StartPoint.Y, 2));
                    double length2 = Math.Sqrt(Math.Pow(X - line.EndPoint.X, 2) + Math.Pow(Y - line.EndPoint.Y, 2));
                    if (length1 < eps)
                    {
                        isEndCatched = true;
                        X = line.EndPoint.X;
                        Y = line.EndPoint.Y;
                        lines.Remove(line);
                        return;
                    }
                    else if (length2 < eps)
                    {
                        isEndCatched = true;
                        X = line.StartPoint.X;
                        Y = line.StartPoint.Y;
                        lines.Remove(line);
                        return;
                    }
                }
            }
        }

        private void MouseMoveOnPictureBox(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (isPressed)
                {
                    X1 = e.X;
                    Y1 = e.Y;
                    pictureBox.Invalidate();
                }
            }
            else if (isMoving)
            {
                if (isPressed && isEndCatched)
                {
                    X1 = e.X;
                    Y1 = e.Y;
                    pictureBox.Invalidate();
                }
            }
        }

        private void MouseUpFromPictureBox(object sender, MouseEventArgs e)
        {
            if (isDrawing || (isMoving && isEndCatched))
            {
                isPressed = false;
                isEndCatched = false;
                PointF newStartPoint = new PointF(X, Y);
                PointF newEndPoint = new PointF(X1, Y1);
                Line newLine = new Line(newStartPoint, newEndPoint);
                lines.Add(newLine);
            }
            else if (isDeleting)
            {
                const float eps = 0.25F;
                isPressed = false;
                foreach (var line in lines)
                {
                    double lengthToStart = Math.Sqrt(Math.Pow(line.StartPoint.X - X, 2) + Math.Pow(line.StartPoint.Y - Y, 2));
                    double lengthToEnd = Math.Sqrt(Math.Pow(line.EndPoint.X - X, 2) + Math.Pow(line.EndPoint.Y - Y, 2));
                    if (Math.Abs(line.Length() - lengthToStart - lengthToEnd) < eps)
                    {
                        lines.Remove(line);
                        pictureBox.Invalidate();
                        return;
                    }
                }
            }
            else if (isMoving)
            {
                isPressed = false;
            }
        }

        private void PaintOnPictureBox(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);

            if (isDrawing || (isMoving && isEndCatched))
            {
                e.Graphics.DrawLine(pen, new PointF(X, Y), new PointF(X1, Y1));
            }

            foreach (var line in lines)
            {
                e.Graphics.DrawLine(pen, line.StartPoint, line.EndPoint);
            }
        }

        private void ClickOnButton(object sender, EventArgs e)
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
