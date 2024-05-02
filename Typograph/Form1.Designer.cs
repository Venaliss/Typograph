namespace Typograph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBoxBefore = new System.Windows.Forms.RichTextBox();
            this.txtBoxAfter = new System.Windows.Forms.RichTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAbsurd = new System.Windows.Forms.Button();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.CopyToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxBefore
            // 
            this.txtBoxBefore.Location = new System.Drawing.Point(32, 63);
            this.txtBoxBefore.Name = "txtBoxBefore";
            this.txtBoxBefore.Size = new System.Drawing.Size(341, 289);
            this.txtBoxBefore.TabIndex = 0;
            this.txtBoxBefore.Text = "";
            // 
            // txtBoxAfter
            // 
            this.txtBoxAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAfter.Location = new System.Drawing.Point(429, 63);
            this.txtBoxAfter.Name = "txtBoxAfter";
            this.txtBoxAfter.Size = new System.Drawing.Size(341, 289);
            this.txtBoxAfter.TabIndex = 1;
            this.txtBoxAfter.Text = "";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit.Location = new System.Drawing.Point(337, 358);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 32);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStrip,
            this.saveFileToolStrip,
            this.exitToolStrip});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(59, 24);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // openFileToolStrip
            // 
            this.openFileToolStrip.Name = "openFileToolStrip";
            this.openFileToolStrip.Size = new System.Drawing.Size(216, 26);
            this.openFileToolStrip.Text = "Открыть файл";
            this.openFileToolStrip.Click += new System.EventHandler(this.openFileToolStrip_Click);
            // 
            // saveFileToolStrip
            // 
            this.saveFileToolStrip.Name = "saveFileToolStrip";
            this.saveFileToolStrip.Size = new System.Drawing.Size(216, 26);
            this.saveFileToolStrip.Text = "Сохранить";
            this.saveFileToolStrip.Click += new System.EventHandler(this.saveFileToolStrip_Click);
            // 
            // exitToolStrip
            // 
            this.exitToolStrip.Name = "exitToolStrip";
            this.exitToolStrip.Size = new System.Drawing.Size(216, 26);
            this.exitToolStrip.Text = "Выход";
            this.exitToolStrip.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(32, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbsurd
            // 
            this.btnAbsurd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbsurd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAbsurd.Location = new System.Drawing.Point(695, 358);
            this.btnAbsurd.Name = "btnAbsurd";
            this.btnAbsurd.Size = new System.Drawing.Size(75, 32);
            this.btnAbsurd.TabIndex = 5;
            this.btnAbsurd.Text = "Абсурд";
            this.btnAbsurd.UseVisualStyleBackColor = false;
            this.btnAbsurd.Click += new System.EventHandler(this.btnAbsurd_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutToolMenu,
            this.CopyToolMenu,
            this.PasteToolMenu});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(64, 24);
            this.toolStripSplitButton1.Text = "Текст";
            // 
            // CopyToolMenu
            // 
            this.CopyToolMenu.Name = "CopyToolMenu";
            this.CopyToolMenu.Size = new System.Drawing.Size(216, 26);
            this.CopyToolMenu.Text = "Копировать";
            this.CopyToolMenu.Click += new System.EventHandler(this.CopyToolMenu_Click);
            // 
            // PasteToolMenu
            // 
            this.PasteToolMenu.Name = "PasteToolMenu";
            this.PasteToolMenu.Size = new System.Drawing.Size(216, 26);
            this.PasteToolMenu.Text = "Вставить";
            this.PasteToolMenu.Click += new System.EventHandler(this.PasteToolMenu_Click);
            // 
            // CutToolMenu
            // 
            this.CutToolMenu.Name = "CutToolMenu";
            this.CutToolMenu.Size = new System.Drawing.Size(216, 26);
            this.CutToolMenu.Text = "Вырезать";
            this.CutToolMenu.Click += new System.EventHandler(this.CutToolMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.btnAbsurd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtBoxAfter);
            this.Controls.Add(this.txtBoxBefore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxBefore;
        private System.Windows.Forms.RichTextBox txtBoxAfter;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAbsurd;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem CopyToolMenu;
        private System.Windows.Forms.ToolStripMenuItem PasteToolMenu;
        private System.Windows.Forms.ToolStripMenuItem CutToolMenu;
    }
}

