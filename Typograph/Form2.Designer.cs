namespace Typograph
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.rule2 = new System.Windows.Forms.CheckBox();
            this.rule16 = new System.Windows.Forms.CheckBox();
            this.rule9 = new System.Windows.Forms.CheckBox();
            this.rule7 = new System.Windows.Forms.CheckBox();
            this.rule1 = new System.Windows.Forms.CheckBox();
            this.myRule1 = new System.Windows.Forms.CheckBox();
            this.myRule2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rule2
            // 
            this.rule2.AutoSize = true;
            this.rule2.Location = new System.Drawing.Point(12, 12);
            this.rule2.Name = "rule2";
            this.rule2.Size = new System.Drawing.Size(201, 21);
            this.rule2.TabIndex = 0;
            this.rule2.Text = "Не более одного пробела";
            this.rule2.UseVisualStyleBackColor = true;
            // 
            // rule16
            // 
            this.rule16.AutoSize = true;
            this.rule16.Location = new System.Drawing.Point(12, 54);
            this.rule16.Name = "rule16";
            this.rule16.Size = new System.Drawing.Size(333, 21);
            this.rule16.TabIndex = 1;
            this.rule16.Text = "Между тире и словом непереносимый пробел";
            this.rule16.UseVisualStyleBackColor = true;
            // 
            // rule9
            // 
            this.rule9.AutoSize = true;
            this.rule9.Location = new System.Drawing.Point(12, 102);
            this.rule9.Name = "rule9";
            this.rule9.Size = new System.Drawing.Size(104, 21);
            this.rule9.TabIndex = 2;
            this.rule9.Text = "Символ + - ";
            this.rule9.UseVisualStyleBackColor = true;
            // 
            // rule7
            // 
            this.rule7.AutoSize = true;
            this.rule7.Location = new System.Drawing.Point(12, 142);
            this.rule7.Name = "rule7";
            this.rule7.Size = new System.Drawing.Size(249, 21);
            this.rule7.TabIndex = 3;
            this.rule7.Text = "Дефиз при цифровом диапазоне";
            this.rule7.UseVisualStyleBackColor = true;
            // 
            // rule1
            // 
            this.rule1.AutoSize = true;
            this.rule1.Location = new System.Drawing.Point(12, 186);
            this.rule1.Name = "rule1";
            this.rule1.Size = new System.Drawing.Size(266, 21);
            this.rule1.TabIndex = 4;
            this.rule1.Text = "Пробелы после знаков препинания";
            this.rule1.UseVisualStyleBackColor = true;
            // 
            // myRule1
            // 
            this.myRule1.AutoSize = true;
            this.myRule1.Location = new System.Drawing.Point(12, 230);
            this.myRule1.Name = "myRule1";
            this.myRule1.Size = new System.Drawing.Size(323, 21);
            this.myRule1.TabIndex = 5;
            this.myRule1.Text = "Заглавные буквы после конца предложения";
            this.myRule1.UseVisualStyleBackColor = true;
            // 
            // myRule2
            // 
            this.myRule2.AutoSize = true;
            this.myRule2.Location = new System.Drawing.Point(12, 269);
            this.myRule2.Name = "myRule2";
            this.myRule2.Size = new System.Drawing.Size(258, 21);
            this.myRule2.TabIndex = 6;
            this.myRule2.Text = "Троеточие заменить многоточием";
            this.myRule2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 306);
            this.Controls.Add(this.myRule2);
            this.Controls.Add(this.myRule1);
            this.Controls.Add(this.rule1);
            this.Controls.Add(this.rule7);
            this.Controls.Add(this.rule9);
            this.Controls.Add(this.rule16);
            this.Controls.Add(this.rule2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox rule2;
        public System.Windows.Forms.CheckBox rule16;
        public System.Windows.Forms.CheckBox rule9;
        public System.Windows.Forms.CheckBox rule7;
        public System.Windows.Forms.CheckBox rule1;
        public System.Windows.Forms.CheckBox myRule1;
        public System.Windows.Forms.CheckBox myRule2;
    }
}