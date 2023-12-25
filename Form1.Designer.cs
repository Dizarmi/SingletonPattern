namespace SingletonPattern
{
    partial class MainForm
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
            this.DatabaseAccessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DatabaseAccessButton
            // 
            this.DatabaseAccessButton.Location = new System.Drawing.Point(178, 79);
            this.DatabaseAccessButton.Name = "DatabaseAccessButton";
            this.DatabaseAccessButton.Size = new System.Drawing.Size(75, 23);
            this.DatabaseAccessButton.TabIndex = 0;
            this.DatabaseAccessButton.Text = "button1";
            this.DatabaseAccessButton.UseVisualStyleBackColor = true;
            this.DatabaseAccessButton.Click += new System.EventHandler(this.DatabaseAccessButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatabaseAccessButton);
            this.Name = "MainForm";
            this.Text = "MainForm ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DatabaseAccessButton;
    }
}

