using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using WebOpener.Manager;
using System.Diagnostics;

namespace WebOpener
{
    public partial class WebOpener : MetroForm
    {
        WriteReadManager _readWrite;
        public WebOpener()
        {
            InitializeComponent();
        }
        private void OpenPage(string page)
        {
            _readWrite = new();
            var processes = Process.GetProcessesByName("Chrome");
            var path = processes.FirstOrDefault()?.MainModule?.FileName;
            Process.Start(path, $"http://{page}");
            _readWrite.Write(pageTxt.Text);
            _readWrite.Read(page);
            CountLbl.Text = $"You opened this page: {WriteReadManager.Count} x";
        }

        private void OpenPageBtn_Click(object sender, EventArgs e)
        {
            OpenPage(pageTxt.Text);
        }
    }
}
