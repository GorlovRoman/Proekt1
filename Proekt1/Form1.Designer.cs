namespace Proekt1
{
    partial class Form1
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
            this.rb_cross = new System.Windows.Forms.RadioButton();
            this.rb_line = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rb_cross
            // 
            this.rb_cross.AutoSize = true;
            this.rb_cross.Location = new System.Drawing.Point(12, 381);
            this.rb_cross.Name = "rb_cross";
            this.rb_cross.Size = new System.Drawing.Size(51, 17);
            this.rb_cross.TabIndex = 0;
            this.rb_cross.TabStop = true;
            this.rb_cross.Text = "Cross";
            this.rb_cross.UseVisualStyleBackColor = true;
            this.rb_cross.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_line
            // 
            this.rb_line.AutoSize = true;
            this.rb_line.Location = new System.Drawing.Point(12, 348);
            this.rb_line.Name = "rb_line";
            this.rb_line.Size = new System.Drawing.Size(41, 17);
            this.rb_line.TabIndex = 1;
            this.rb_line.TabStop = true;
            this.rb_line.Text = "line";
            this.rb_line.UseVisualStyleBackColor = true;
            this.rb_line.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 422);
            this.Controls.Add(this.rb_line);
            this.Controls.Add(this.rb_cross);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_cross;
        private System.Windows.Forms.RadioButton rb_line;
    }
}

