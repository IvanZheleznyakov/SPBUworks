namespace RunningButton
{
    partial class RunningButtonForm
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
            this.RunningButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunningButton
            // 
            this.RunningButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunningButton.Location = new System.Drawing.Point(29, 45);
            this.RunningButton.Name = "RunningButton";
            this.RunningButton.Size = new System.Drawing.Size(229, 220);
            this.RunningButton.TabIndex = 0;
            this.RunningButton.TabStop = false;
            this.RunningButton.Text = "YOU SHALL NOT CATCH ME";
            this.RunningButton.UseVisualStyleBackColor = true;
            this.RunningButton.Click += new System.EventHandler(this.OnRunningButtonClick);
            this.RunningButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveOnRunningButton);
            // 
            // RunningButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.RunningButton);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "RunningButtonForm";
            this.Text = "RunningButton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunningButton;
    }
}

