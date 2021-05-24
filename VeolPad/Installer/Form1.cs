using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using Shell32;
using IWshRuntimeLibrary;


namespace Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"%appdata%\Amanche\VeolPad\");
            System.IO.File.WriteAllText(@"%appdata%\Amanche\VeolPad\SetupPath.bat", @"set VeolPad=%appdata%\Amanche\VeolPad");
            WebClient ForDownload = new WebClient();
            ForDownload.DownloadFile("https://raw.githubusercontent.com/AlerMiV/VeolPad/realises/VeolPad/VeolPad/bin/Debug/VeolPad.exe", @"%appdata%\Amanche\VeolPad\VeolPad.exe");
            Process.Start(@"%appdata%\Amanche\VeolPad\SetupPath.bat");
            Process.Start(@"%appdata%\Amanche\VeolPad\VeolPad.exe");
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                ;
            else
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
