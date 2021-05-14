using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeolPad.Windows;
using VeolPad.Dialogs;

namespace VeolPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void VeolTextEditor_TextChanged_1(object sender, EventArgs e)
        {
            TextLenghtValue.Text = VeolTextEditor.TextLength.ToString();
            TextLinesValue.Text = VeolTextEditor.Lines.Count().ToString();
        }

        private void VeolStrip_File_Open_Click(object sender, EventArgs e)
        {
            if (VeolDialogOpen.ShowDialog() == DialogResult.Cancel)
            {
                Form Dialog = new SaveError();
                Dialog.ShowDialog();
            }    
            else
            {
                string Path = VeolDialogOpen.FileName;
                string Text = System.IO.File.ReadAllText(Path);
                VeolTextEditor.Text = Text;
            }
        }

        private void VeolStrip_File_SaveAs_Click(object sender, EventArgs e)
        {
            if (VeolDialogOpen.ShowDialog() == DialogResult.Cancel)
            {
            }
            else
            {
                string Path = VeolDialogSave.FileName;
                string Text = VeolTextEditor.Text;
                System.IO.File.WriteAllText(Path, Text);
            }
        }

        private void VeolStrip_Edit_Copy_Click(object sender, EventArgs e)
        {
            VeolTextEditor.Copy();
        }

        private void VeolStrip_Edit_Cut_Click(object sender, EventArgs e)
        {
            VeolTextEditor.Cut();
        }

        private void VeolStrip_Edit_Paste_Click(object sender, EventArgs e)
        {
            VeolTextEditor.Paste();
        }

        private void VeolStrip_Edit_SelectAll_Click(object sender, EventArgs e)
        {
            VeolTextEditor.SelectAll();
        }

        private void VeolStrip_More_About_Click(object sender, EventArgs e)
        {
            Form Dialog = new About();
            Dialog.ShowDialog();
        }
    }
}
