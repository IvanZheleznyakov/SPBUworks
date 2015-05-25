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
            this.LayoutForOutputResult = new System.Windows.Forms.FlowLayoutPanel();
            this.TableLayoutForUpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutForDownButtons = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // LayoutForOutputResult
            // 
            this.LayoutForOutputResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutForOutputResult.AutoSize = true;
            this.LayoutForOutputResult.Location = new System.Drawing.Point(12, 12);
            this.LayoutForOutputResult.Name = "LayoutForOutputResult";
            this.LayoutForOutputResult.Size = new System.Drawing.Size(208, 50);
            this.LayoutForOutputResult.TabIndex = 0;
            // 
            // TableLayoutForUpButtons
            // 
            this.TableLayoutForUpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutForUpButtons.AutoSize = true;
            this.TableLayoutForUpButtons.ColumnCount = 4;
            this.TableLayoutForUpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutForUpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutForUpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutForUpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutForUpButtons.Location = new System.Drawing.Point(12, 68);
            this.TableLayoutForUpButtons.Name = "TableLayoutForUpButtons";
            this.TableLayoutForUpButtons.RowCount = 4;
            this.TableLayoutForUpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutForUpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutForUpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutForUpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutForUpButtons.Size = new System.Drawing.Size(208, 196);
            this.TableLayoutForUpButtons.TabIndex = 1;
            // 
            // TableLayoutForDownButtons
            // 
            this.TableLayoutForDownButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutForDownButtons.AutoSize = true;
            this.TableLayoutForDownButtons.ColumnCount = 3;
            this.TableLayoutForDownButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutForDownButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutForDownButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutForDownButtons.Location = new System.Drawing.Point(12, 263);
            this.TableLayoutForDownButtons.Name = "TableLayoutForDownButtons";
            this.TableLayoutForDownButtons.RowCount = 1;
            this.TableLayoutForDownButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutForDownButtons.Size = new System.Drawing.Size(208, 49);
            this.TableLayoutForDownButtons.TabIndex = 2;
            // 
            // MyCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 324);
            this.Controls.Add(this.TableLayoutForDownButtons);
            this.Controls.Add(this.TableLayoutForUpButtons);
            this.Controls.Add(this.LayoutForOutputResult);
            this.MinimumSize = new System.Drawing.Size(248, 363);
            this.Name = "MyCalculatorForm";
            this.Text = "MyCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LayoutForOutputResult;
        private System.Windows.Forms.TableLayoutPanel TableLayoutForUpButtons;
        private System.Windows.Forms.TableLayoutPanel TableLayoutForDownButtons;
    }
}

