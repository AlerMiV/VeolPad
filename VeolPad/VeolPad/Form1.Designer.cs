
namespace VeolPad
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
            this.VeolStrip = new System.Windows.Forms.MenuStrip();
            this.VeolStrip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.VeolStrip_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.VeolStrip_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.VeolStrip_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.VeolStrip_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.VeolDialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.VeolDialogSave = new System.Windows.Forms.SaveFileDialog();
            this.VeolData = new System.Windows.Forms.Panel();
            this.TextLinesValue = new System.Windows.Forms.Label();
            this.TextLines = new System.Windows.Forms.Label();
            this.TextLenghtValue = new System.Windows.Forms.Label();
            this.TextLenght = new System.Windows.Forms.Label();
            this.VeolTextEditor = new System.Windows.Forms.RichTextBox();
            this.VeolStrip.SuspendLayout();
            this.VeolData.SuspendLayout();
            this.SuspendLayout();
            // 
            // VeolStrip
            // 
            this.VeolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VeolStrip_File});
            this.VeolStrip.Location = new System.Drawing.Point(0, 0);
            this.VeolStrip.Name = "VeolStrip";
            this.VeolStrip.Size = new System.Drawing.Size(800, 24);
            this.VeolStrip.TabIndex = 0;
            this.VeolStrip.Text = "menuStrip1";
            // 
            // VeolStrip_File
            // 
            this.VeolStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VeolStrip_File_New,
            this.VeolStrip_File_Open,
            this.VeolStrip_File_Save,
            this.VeolStrip_File_SaveAs});
            this.VeolStrip_File.Image = global::VeolPad.VeolIcons.FileIcon;
            this.VeolStrip_File.Name = "VeolStrip_File";
            this.VeolStrip_File.Size = new System.Drawing.Size(53, 20);
            this.VeolStrip_File.Text = "File";
            // 
            // VeolStrip_File_New
            // 
            this.VeolStrip_File_New.Image = global::VeolPad.VeolIcons.NewFileIcon;
            this.VeolStrip_File_New.Name = "VeolStrip_File_New";
            this.VeolStrip_File_New.Size = new System.Drawing.Size(180, 22);
            this.VeolStrip_File_New.Text = "New";
            // 
            // VeolStrip_File_Open
            // 
            this.VeolStrip_File_Open.Image = global::VeolPad.VeolIcons.OpenFileIcon;
            this.VeolStrip_File_Open.Name = "VeolStrip_File_Open";
            this.VeolStrip_File_Open.Size = new System.Drawing.Size(180, 22);
            this.VeolStrip_File_Open.Text = "Open";
            // 
            // VeolStrip_File_Save
            // 
            this.VeolStrip_File_Save.Image = global::VeolPad.VeolIcons.SaveFileIcon;
            this.VeolStrip_File_Save.Name = "VeolStrip_File_Save";
            this.VeolStrip_File_Save.Size = new System.Drawing.Size(180, 22);
            this.VeolStrip_File_Save.Text = "Save";
            // 
            // VeolStrip_File_SaveAs
            // 
            this.VeolStrip_File_SaveAs.Image = global::VeolPad.VeolIcons.SaveAsFileIcon;
            this.VeolStrip_File_SaveAs.Name = "VeolStrip_File_SaveAs";
            this.VeolStrip_File_SaveAs.Size = new System.Drawing.Size(180, 22);
            this.VeolStrip_File_SaveAs.Text = "Save As";
            // 
            // VeolDialogOpen
            // 
            this.VeolDialogOpen.FileName = "openFileDialog1";
            // 
            // VeolData
            // 
            this.VeolData.BackColor = System.Drawing.SystemColors.Window;
            this.VeolData.Controls.Add(this.TextLinesValue);
            this.VeolData.Controls.Add(this.TextLines);
            this.VeolData.Controls.Add(this.TextLenghtValue);
            this.VeolData.Controls.Add(this.TextLenght);
            this.VeolData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VeolData.Location = new System.Drawing.Point(0, 430);
            this.VeolData.Name = "VeolData";
            this.VeolData.Size = new System.Drawing.Size(800, 20);
            this.VeolData.TabIndex = 3;
            // 
            // TextLinesValue
            // 
            this.TextLinesValue.AutoSize = true;
            this.TextLinesValue.Location = new System.Drawing.Point(181, 4);
            this.TextLinesValue.Name = "TextLinesValue";
            this.TextLinesValue.Size = new System.Drawing.Size(13, 13);
            this.TextLinesValue.TabIndex = 3;
            this.TextLinesValue.Text = "0";
            // 
            // TextLines
            // 
            this.TextLines.AutoSize = true;
            this.TextLines.Location = new System.Drawing.Point(127, 4);
            this.TextLines.Name = "TextLines";
            this.TextLines.Size = new System.Drawing.Size(58, 13);
            this.TextLines.TabIndex = 2;
            this.TextLines.Text = "Text lines: ";
            // 
            // TextLenghtValue
            // 
            this.TextLenghtValue.AutoSize = true;
            this.TextLenghtValue.Location = new System.Drawing.Point(62, 4);
            this.TextLenghtValue.Name = "TextLenghtValue";
            this.TextLenghtValue.Size = new System.Drawing.Size(13, 13);
            this.TextLenghtValue.TabIndex = 1;
            this.TextLenghtValue.Text = "0";
            // 
            // TextLenght
            // 
            this.TextLenght.AutoSize = true;
            this.TextLenght.Location = new System.Drawing.Point(3, 4);
            this.TextLenght.Name = "TextLenght";
            this.TextLenght.Size = new System.Drawing.Size(66, 13);
            this.TextLenght.TabIndex = 0;
            this.TextLenght.Text = "Text lenght: ";
            // 
            // VeolTextEditor
            // 
            this.VeolTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VeolTextEditor.Location = new System.Drawing.Point(0, 24);
            this.VeolTextEditor.Name = "VeolTextEditor";
            this.VeolTextEditor.Size = new System.Drawing.Size(800, 426);
            this.VeolTextEditor.TabIndex = 4;
            this.VeolTextEditor.Text = "";
            this.VeolTextEditor.TextChanged += new System.EventHandler(this.VeolTextEditor_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VeolData);
            this.Controls.Add(this.VeolTextEditor);
            this.Controls.Add(this.VeolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.VeolStrip;
            this.Name = "Form1";
            this.Text = "VeolPad - Universal notepad";
            this.VeolStrip.ResumeLayout(false);
            this.VeolStrip.PerformLayout();
            this.VeolData.ResumeLayout(false);
            this.VeolData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip VeolStrip;
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_File;
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_File_New;
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_File_Open;
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_File_Save;
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_File_SaveAs;
        private System.Windows.Forms.OpenFileDialog VeolDialogOpen;
        private System.Windows.Forms.SaveFileDialog VeolDialogSave;
        private System.Windows.Forms.Panel VeolData;
        private System.Windows.Forms.Label TextLinesValue;
        private System.Windows.Forms.Label TextLines;
        private System.Windows.Forms.Label TextLenghtValue;
        private System.Windows.Forms.Label TextLenght;
        private System.Windows.Forms.RichTextBox VeolTextEditor;
    }
}

