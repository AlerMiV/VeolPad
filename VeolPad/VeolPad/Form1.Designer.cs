
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
            this.VeolStrip_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.VeolStrip_Edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.VeolStrip_Edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.VeolStrip_Edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.VeolStrip_Edit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.VeolStrip_Edit_More = new System.Windows.Forms.ToolStripMenuItem();
            this.VeolStrip_More_GetUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.VeolStrip_More_About = new System.Windows.Forms.ToolStripMenuItem();
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
            resources.ApplyResources(this.VeolStrip, "VeolStrip");
            this.VeolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VeolStrip_File,
            this.VeolStrip_Edit,
            this.VeolStrip_Edit_More});
            this.VeolStrip.Name = "VeolStrip";
            // 
            // VeolStrip_File
            // 
            resources.ApplyResources(this.VeolStrip_File, "VeolStrip_File");
            this.VeolStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VeolStrip_File_New,
            this.VeolStrip_File_Open,
            this.VeolStrip_File_Save,
            this.VeolStrip_File_SaveAs});
            this.VeolStrip_File.Image = global::VeolPad.VeolIcons.FileIcon;
            this.VeolStrip_File.Name = "VeolStrip_File";
            // 
            // VeolStrip_File_New
            // 
            resources.ApplyResources(this.VeolStrip_File_New, "VeolStrip_File_New");
            this.VeolStrip_File_New.Image = global::VeolPad.VeolIcons.NewFileIcon;
            this.VeolStrip_File_New.Name = "VeolStrip_File_New";
            // 
            // VeolStrip_File_Open
            // 
            resources.ApplyResources(this.VeolStrip_File_Open, "VeolStrip_File_Open");
            this.VeolStrip_File_Open.Image = global::VeolPad.VeolIcons.OpenFileIcon;
            this.VeolStrip_File_Open.Name = "VeolStrip_File_Open";
            this.VeolStrip_File_Open.Click += new System.EventHandler(this.VeolStrip_File_Open_Click);
            // 
            // VeolStrip_File_Save
            // 
            resources.ApplyResources(this.VeolStrip_File_Save, "VeolStrip_File_Save");
            this.VeolStrip_File_Save.Image = global::VeolPad.VeolIcons.SaveFileIcon;
            this.VeolStrip_File_Save.Name = "VeolStrip_File_Save";
            // 
            // VeolStrip_File_SaveAs
            // 
            resources.ApplyResources(this.VeolStrip_File_SaveAs, "VeolStrip_File_SaveAs");
            this.VeolStrip_File_SaveAs.Image = global::VeolPad.VeolIcons.SaveAsFileIcon;
            this.VeolStrip_File_SaveAs.Name = "VeolStrip_File_SaveAs";
            this.VeolStrip_File_SaveAs.Click += new System.EventHandler(this.VeolStrip_File_SaveAs_Click);
            // 
            // VeolStrip_Edit
            // 
            resources.ApplyResources(this.VeolStrip_Edit, "VeolStrip_Edit");
            this.VeolStrip_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VeolStrip_Edit_Copy,
            this.VeolStrip_Edit_Cut,
            this.VeolStrip_Edit_Paste,
            this.VeolStrip_Edit_SelectAll});
            this.VeolStrip_Edit.Image = global::VeolPad.VeolIcons.EditText;
            this.VeolStrip_Edit.Name = "VeolStrip_Edit";
            // 
            // VeolStrip_Edit_Copy
            // 
            resources.ApplyResources(this.VeolStrip_Edit_Copy, "VeolStrip_Edit_Copy");
            this.VeolStrip_Edit_Copy.Image = global::VeolPad.VeolIcons.CopyText;
            this.VeolStrip_Edit_Copy.Name = "VeolStrip_Edit_Copy";
            this.VeolStrip_Edit_Copy.Click += new System.EventHandler(this.VeolStrip_Edit_Copy_Click);
            // 
            // VeolStrip_Edit_Cut
            // 
            resources.ApplyResources(this.VeolStrip_Edit_Cut, "VeolStrip_Edit_Cut");
            this.VeolStrip_Edit_Cut.Image = global::VeolPad.VeolIcons.CutText;
            this.VeolStrip_Edit_Cut.Name = "VeolStrip_Edit_Cut";
            this.VeolStrip_Edit_Cut.Click += new System.EventHandler(this.VeolStrip_Edit_Cut_Click);
            // 
            // VeolStrip_Edit_Paste
            // 
            resources.ApplyResources(this.VeolStrip_Edit_Paste, "VeolStrip_Edit_Paste");
            this.VeolStrip_Edit_Paste.Image = global::VeolPad.VeolIcons.PasteText;
            this.VeolStrip_Edit_Paste.Name = "VeolStrip_Edit_Paste";
            this.VeolStrip_Edit_Paste.Click += new System.EventHandler(this.VeolStrip_Edit_Paste_Click);
            // 
            // VeolStrip_Edit_SelectAll
            // 
            resources.ApplyResources(this.VeolStrip_Edit_SelectAll, "VeolStrip_Edit_SelectAll");
            this.VeolStrip_Edit_SelectAll.Image = global::VeolPad.VeolIcons.SelectAllText;
            this.VeolStrip_Edit_SelectAll.Name = "VeolStrip_Edit_SelectAll";
            this.VeolStrip_Edit_SelectAll.Click += new System.EventHandler(this.VeolStrip_Edit_SelectAll_Click);
            // 
            // VeolStrip_Edit_More
            // 
            resources.ApplyResources(this.VeolStrip_Edit_More, "VeolStrip_Edit_More");
            this.VeolStrip_Edit_More.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VeolStrip_More_GetUpdates,
            this.VeolStrip_More_About});
            this.VeolStrip_Edit_More.Image = global::VeolPad.VeolIcons.MenuMore;
            this.VeolStrip_Edit_More.Name = "VeolStrip_Edit_More";
            // 
            // VeolStrip_More_GetUpdates
            // 
            resources.ApplyResources(this.VeolStrip_More_GetUpdates, "VeolStrip_More_GetUpdates");
            this.VeolStrip_More_GetUpdates.Image = global::VeolPad.VeolIcons.GetUpdates;
            this.VeolStrip_More_GetUpdates.Name = "VeolStrip_More_GetUpdates";
            this.VeolStrip_More_GetUpdates.Click += new System.EventHandler(this.VeolStrip_More_GetUpdates_Click);
            // 
            // VeolStrip_More_About
            // 
            resources.ApplyResources(this.VeolStrip_More_About, "VeolStrip_More_About");
            this.VeolStrip_More_About.Image = global::VeolPad.VeolIcons.AboutApp;
            this.VeolStrip_More_About.Name = "VeolStrip_More_About";
            this.VeolStrip_More_About.Click += new System.EventHandler(this.VeolStrip_More_About_Click);
            // 
            // VeolDialogOpen
            // 
            this.VeolDialogOpen.FileName = "openFileDialog1";
            resources.ApplyResources(this.VeolDialogOpen, "VeolDialogOpen");
            // 
            // VeolDialogSave
            // 
            resources.ApplyResources(this.VeolDialogSave, "VeolDialogSave");
            // 
            // VeolData
            // 
            resources.ApplyResources(this.VeolData, "VeolData");
            this.VeolData.BackColor = System.Drawing.SystemColors.Window;
            this.VeolData.Controls.Add(this.TextLinesValue);
            this.VeolData.Controls.Add(this.TextLines);
            this.VeolData.Controls.Add(this.TextLenghtValue);
            this.VeolData.Controls.Add(this.TextLenght);
            this.VeolData.Name = "VeolData";
            // 
            // TextLinesValue
            // 
            resources.ApplyResources(this.TextLinesValue, "TextLinesValue");
            this.TextLinesValue.Name = "TextLinesValue";
            // 
            // TextLines
            // 
            resources.ApplyResources(this.TextLines, "TextLines");
            this.TextLines.Name = "TextLines";
            // 
            // TextLenghtValue
            // 
            resources.ApplyResources(this.TextLenghtValue, "TextLenghtValue");
            this.TextLenghtValue.Name = "TextLenghtValue";
            // 
            // TextLenght
            // 
            resources.ApplyResources(this.TextLenght, "TextLenght");
            this.TextLenght.Name = "TextLenght";
            // 
            // VeolTextEditor
            // 
            resources.ApplyResources(this.VeolTextEditor, "VeolTextEditor");
            this.VeolTextEditor.Name = "VeolTextEditor";
            this.VeolTextEditor.TextChanged += new System.EventHandler(this.VeolTextEditor_TextChanged_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VeolData);
            this.Controls.Add(this.VeolTextEditor);
            this.Controls.Add(this.VeolStrip);
            this.MainMenuStrip = this.VeolStrip;
            this.Name = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_Edit;
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_Edit_More;
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_Edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_Edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_Edit_Paste;
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_Edit_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_More_About;
        private System.Windows.Forms.ToolStripMenuItem VeolStrip_More_GetUpdates;
    }
}

