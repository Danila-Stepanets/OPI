namespace Lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.CalculateAreaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(100, 58);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(197, 22);
            this.radiusTextBox.TabIndex = 0;
            // 
            // CalculateAreaButton
            // 
            this.CalculateAreaButton.Location = new System.Drawing.Point(117, 124);
            this.CalculateAreaButton.Name = "CalculateAreaButton";
            this.CalculateAreaButton.Size = new System.Drawing.Size(152, 23);
            this.CalculateAreaButton.TabIndex = 2;
            this.CalculateAreaButton.Text = "Обрахувати";
            this.CalculateAreaButton.UseVisualStyleBackColor = true;
            this.CalculateAreaButton.Click += new System.EventHandler(this.CalculateAreaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Радіус кола";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateAreaButton);
            this.Controls.Add(this.radiusTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Button CalculateAreaButton;
        private System.Windows.Forms.Label label1;
    }
}

