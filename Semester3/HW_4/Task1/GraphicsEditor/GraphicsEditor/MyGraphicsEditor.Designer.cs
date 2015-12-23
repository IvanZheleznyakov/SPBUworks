namespace GraphicsEditor
{
    partial class MyGraphicsEditor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.drawButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainTableLayout.SuspendLayout();
            this.buttonsTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(3, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 205);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTableLayout.AutoSize = true;
            this.mainTableLayout.ColumnCount = 1;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.Controls.Add(this.pictureBox1, 0, 1);
            this.mainTableLayout.Controls.Add(this.buttonsTableLayout, 0, 0);
            this.mainTableLayout.Location = new System.Drawing.Point(12, 12);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.35766F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.64233F));
            this.mainTableLayout.Size = new System.Drawing.Size(416, 275);
            this.mainTableLayout.TabIndex = 1;
            // 
            // buttonsTableLayout
            // 
            this.buttonsTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsTableLayout.AutoSize = true;
            this.buttonsTableLayout.ColumnCount = 5;
            this.buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayout.Controls.Add(this.drawButton, 0, 0);
            this.buttonsTableLayout.Controls.Add(this.moveButton, 1, 0);
            this.buttonsTableLayout.Controls.Add(this.deleteButton, 2, 0);
            this.buttonsTableLayout.Controls.Add(this.undoButton, 3, 0);
            this.buttonsTableLayout.Controls.Add(this.redoButton, 4, 0);
            this.buttonsTableLayout.Location = new System.Drawing.Point(3, 3);
            this.buttonsTableLayout.Name = "buttonsTableLayout";
            this.buttonsTableLayout.RowCount = 1;
            this.buttonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayout.Size = new System.Drawing.Size(410, 58);
            this.buttonsTableLayout.TabIndex = 1;
            // 
            // drawButton
            // 
            this.drawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawButton.AutoSize = true;
            this.drawButton.Location = new System.Drawing.Point(3, 3);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(76, 52);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // moveButton
            // 
            this.moveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveButton.AutoSize = true;
            this.moveButton.Location = new System.Drawing.Point(85, 3);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(76, 52);
            this.moveButton.TabIndex = 1;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.AutoSize = true;
            this.deleteButton.Location = new System.Drawing.Point(167, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(76, 52);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // undoButton
            // 
            this.undoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.undoButton.AutoSize = true;
            this.undoButton.Location = new System.Drawing.Point(249, 3);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(76, 52);
            this.undoButton.TabIndex = 3;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            // 
            // redoButton
            // 
            this.redoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redoButton.AutoSize = true;
            this.redoButton.Location = new System.Drawing.Point(331, 3);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(76, 52);
            this.redoButton.TabIndex = 4;
            this.redoButton.Text = "Redo";
            this.redoButton.UseVisualStyleBackColor = true;
            // 
            // MyGraphicsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 298);
            this.Controls.Add(this.mainTableLayout);
            this.MinimumSize = new System.Drawing.Size(450, 330);
            this.Name = "MyGraphicsEditor";
            this.Text = "MyGraphicsEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainTableLayout.ResumeLayout(false);
            this.mainTableLayout.PerformLayout();
            this.buttonsTableLayout.ResumeLayout(false);
            this.buttonsTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayout;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;


    }
}

