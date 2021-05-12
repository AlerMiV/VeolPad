using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeolPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VeolTextEditor_TextChanged(object sender, EventArgs e)
        {
            TextLenghtValue.Text = VeolTextEditor.TextLength.ToString();
            TextLinesValue.Text = VeolTextEditor.Lines.Count().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VeolTextEditor_TextChanged_1(object sender, EventArgs e)
        {
            TextLenghtValue.Text = VeolTextEditor.TextLength.ToString();
            TextLinesValue.Text = VeolTextEditor.Lines.Count().ToString();
        }
    }
}
