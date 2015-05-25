namespace Calculator
{
    partial class MyCalculatorForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonEqual = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonMultiplication = new System.Windows.Forms.Button();
            this.ButtonDivision = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonEqual
            // 
            this.ButtonEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEqual.AutoSize = true;
            this.ButtonEqual.Location = new System.Drawing.Point(159, 263);
            this.ButtonEqual.Name = "ButtonEqual";
            this.ButtonEqual.Size = new System.Drawing.Size(46, 44);
            this.ButtonEqual.TabIndex = 0;
            this.ButtonEqual.Text = "=";
            this.ButtonEqual.UseVisualStyleBackColor = true;
            // 
            // ButtonPoint
            // 
            this.ButtonPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPoint.AutoSize = true;
            this.ButtonPoint.Location = new System.Drawing.Point(107, 263);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new System.Drawing.Size(46, 44);
            this.ButtonPoint.TabIndex = 1;
            this.ButtonPoint.Text = ".";
            this.ButtonPoint.UseVisualStyleBackColor = true;
            // 
            // Button0
            // 
            this.Button0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button0.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Button0, 2);
            this.Button0.Location = new System.Drawing.Point(3, 263);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(98, 44);
            this.Button0.TabIndex = 2;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPlus.AutoSize = true;
            this.ButtonPlus.Location = new System.Drawing.Point(159, 213);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(46, 44);
            this.ButtonPlus.TabIndex = 0;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinus.AutoSize = true;
            this.ButtonMinus.Location = new System.Drawing.Point(159, 165);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(46, 42);
            this.ButtonMinus.TabIndex = 1;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            // 
            // ButtonMultiplication
            // 
            this.ButtonMultiplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMultiplication.AutoSize = true;
            this.ButtonMultiplication.Location = new System.Drawing.Point(159, 117);
            this.ButtonMultiplication.Name = "ButtonMultiplication";
            this.ButtonMultiplication.Size = new System.Drawing.Size(46, 42);
            this.ButtonMultiplication.TabIndex = 2;
            this.ButtonMultiplication.Text = "*";
            this.ButtonMultiplication.UseVisualStyleBackColor = true;
            // 
            // ButtonDivision
            // 
            this.ButtonDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDivision.AutoSize = true;
            this.ButtonDivision.Location = new System.Drawing.Point(159, 69);
            this.ButtonDivision.Name = "ButtonDivision";
            this.ButtonDivision.Size = new System.Drawing.Size(46, 42);
            this.ButtonDivision.TabIndex = 3;
            this.ButtonDivision.Text = "/";
            this.ButtonDivision.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Button0, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ButtonPoint, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.ButtonEqual, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.ButtonPlus, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMinus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMultiplication, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDivision, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.43306F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.71339F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.71339F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.48387F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.48387F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 310);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // MyCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 334);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(248, 363);
            this.Name = "MyCalculatorForm";
            this.Text = "MyCalculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonEqual;
        private System.Windows.Forms.Button ButtonPoint;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonMultiplication;
        private System.Windows.Forms.Button ButtonDivision;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

