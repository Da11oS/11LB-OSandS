namespace ОСИС_11ЛБ_Файловые_операции
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FunctionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderButton = new System.Windows.Forms.Button();
            this.WriteUnitButton = new System.Windows.Forms.Button();
            this.UnitReadButton = new System.Windows.Forms.Button();
            this.RadLineButton = new System.Windows.Forms.Button();
            this.CloseForReadButton = new System.Windows.Forms.Button();
            this.OpenForReadingButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.WriteLineButton = new System.Windows.Forms.Button();
            this.CloseForWriteButton = new System.Windows.Forms.Button();
            this.OpenForWriteButton = new System.Windows.Forms.Button();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.ForFileLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 310);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(361, 74);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem1,
            this.FunctionToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem1
            // 
            this.FileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1";
            this.FileToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem1.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click_1);
            // 
            // FunctionToolStripMenuItem2
            // 
            this.FunctionToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПапкуToolStripMenuItem});
            this.FunctionToolStripMenuItem2.Name = "FunctionToolStripMenuItem2";
            this.FunctionToolStripMenuItem2.Size = new System.Drawing.Size(68, 20);
            this.FunctionToolStripMenuItem2.Text = "Функции";
            // 
            // создатьПапкуToolStripMenuItem
            // 
            this.создатьПапкуToolStripMenuItem.Name = "создатьПапкуToolStripMenuItem";
            this.создатьПапкуToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.создатьПапкуToolStripMenuItem.Text = "Создать папку";
            this.создатьПапкуToolStripMenuItem.Click += new System.EventHandler(this.СоздатьПапкуToolStripMenuItem_Click_1);
            // 
            // FolderButton
            // 
            this.FolderButton.Location = new System.Drawing.Point(102, 40);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(166, 23);
            this.FolderButton.TabIndex = 2;
            this.FolderButton.Text = "Папка";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // WriteUnitButton
            // 
            this.WriteUnitButton.Location = new System.Drawing.Point(11, 227);
            this.WriteUnitButton.Name = "WriteUnitButton";
            this.WriteUnitButton.Size = new System.Drawing.Size(166, 23);
            this.WriteUnitButton.TabIndex = 3;
            this.WriteUnitButton.Text = "Запись блока";
            this.WriteUnitButton.UseVisualStyleBackColor = true;
            this.WriteUnitButton.Click += new System.EventHandler(this.WriteUnitButton_Click);
            // 
            // UnitReadButton
            // 
            this.UnitReadButton.Location = new System.Drawing.Point(183, 227);
            this.UnitReadButton.Name = "UnitReadButton";
            this.UnitReadButton.Size = new System.Drawing.Size(166, 23);
            this.UnitReadButton.TabIndex = 3;
            this.UnitReadButton.Text = "Чтение блока";
            this.UnitReadButton.UseVisualStyleBackColor = true;
            this.UnitReadButton.Click += new System.EventHandler(this.UnitReadButton_Click);
            // 
            // RadLineButton
            // 
            this.RadLineButton.Location = new System.Drawing.Point(183, 98);
            this.RadLineButton.Name = "RadLineButton";
            this.RadLineButton.Size = new System.Drawing.Size(166, 23);
            this.RadLineButton.TabIndex = 3;
            this.RadLineButton.Text = "Чтение строки";
            this.RadLineButton.UseVisualStyleBackColor = true;
            this.RadLineButton.Click += new System.EventHandler(this.RadLineButton_Click);
            // 
            // CloseForReadButton
            // 
            this.CloseForReadButton.Location = new System.Drawing.Point(183, 127);
            this.CloseForReadButton.Name = "CloseForReadButton";
            this.CloseForReadButton.Size = new System.Drawing.Size(166, 23);
            this.CloseForReadButton.TabIndex = 3;
            this.CloseForReadButton.Text = "Закрыть для чтения";
            this.CloseForReadButton.UseVisualStyleBackColor = true;
            this.CloseForReadButton.Click += new System.EventHandler(this.CloseForReadButton_Click);
            // 
            // OpenForReadingButton
            // 
            this.OpenForReadingButton.Location = new System.Drawing.Point(183, 69);
            this.OpenForReadingButton.Name = "OpenForReadingButton";
            this.OpenForReadingButton.Size = new System.Drawing.Size(166, 23);
            this.OpenForReadingButton.TabIndex = 3;
            this.OpenForReadingButton.Text = "Открыть для чтения";
            this.OpenForReadingButton.UseVisualStyleBackColor = true;
            this.OpenForReadingButton.Click += new System.EventHandler(this.OpenForReadingButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(136, 256);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 3;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // WriteLineButton
            // 
            this.WriteLineButton.Location = new System.Drawing.Point(11, 98);
            this.WriteLineButton.Name = "WriteLineButton";
            this.WriteLineButton.Size = new System.Drawing.Size(166, 23);
            this.WriteLineButton.TabIndex = 3;
            this.WriteLineButton.Text = "Запись строки";
            this.WriteLineButton.UseVisualStyleBackColor = true;
            this.WriteLineButton.Click += new System.EventHandler(this.WriteLineButton_Click);
            // 
            // CloseForWriteButton
            // 
            this.CloseForWriteButton.Location = new System.Drawing.Point(11, 127);
            this.CloseForWriteButton.Name = "CloseForWriteButton";
            this.CloseForWriteButton.Size = new System.Drawing.Size(166, 23);
            this.CloseForWriteButton.TabIndex = 3;
            this.CloseForWriteButton.Text = "Закрыть для записи";
            this.CloseForWriteButton.UseVisualStyleBackColor = true;
            this.CloseForWriteButton.Click += new System.EventHandler(this.CloseForWriteButton_Click);
            // 
            // OpenForWriteButton
            // 
            this.OpenForWriteButton.Location = new System.Drawing.Point(11, 69);
            this.OpenForWriteButton.Name = "OpenForWriteButton";
            this.OpenForWriteButton.Size = new System.Drawing.Size(166, 23);
            this.OpenForWriteButton.TabIndex = 3;
            this.OpenForWriteButton.Text = "Открыть для записи";
            this.OpenForWriteButton.UseVisualStyleBackColor = true;
            this.OpenForWriteButton.Click += new System.EventHandler(this.OpenForWriteButton_Click);
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(77, 201);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(100, 20);
            this.FileTextBox.TabIndex = 4;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(183, 201);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(100, 20);
            this.PositionTextBox.TabIndex = 4;
            // 
            // ForFileLabel
            // 
            this.ForFileLabel.AutoSize = true;
            this.ForFileLabel.Location = new System.Drawing.Point(102, 174);
            this.ForFileLabel.Name = "ForFileLabel";
            this.ForFileLabel.Size = new System.Drawing.Size(63, 13);
            this.ForFileLabel.TabIndex = 5;
            this.ForFileLabel.Text = "Для файла";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(205, 174);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(51, 13);
            this.PositionLabel.TabIndex = 5;
            this.PositionLabel.Text = "Позиция";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 384);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.ForFileLabel);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.OpenForWriteButton);
            this.Controls.Add(this.CloseForReadButton);
            this.Controls.Add(this.CloseForWriteButton);
            this.Controls.Add(this.OpenForReadingButton);
            this.Controls.Add(this.WriteLineButton);
            this.Controls.Add(this.RadLineButton);
            this.Controls.Add(this.UnitReadButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.WriteUnitButton);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FunctionToolStripMenuItem2;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.Button WriteUnitButton;
        private System.Windows.Forms.Button UnitReadButton;
        private System.Windows.Forms.Button RadLineButton;
        private System.Windows.Forms.Button CloseForReadButton;
        private System.Windows.Forms.Button OpenForReadingButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button WriteLineButton;
        private System.Windows.Forms.Button CloseForWriteButton;
        private System.Windows.Forms.Button OpenForWriteButton;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label ForFileLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem создатьПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    }
}

