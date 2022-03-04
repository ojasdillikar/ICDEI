using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace ICDEI
{
    public partial class Safegaurdkey : Form
    {
        int _charIndex1 = 0;
        int _charIndex2 = 0;
        string output;
        string check = "Conversation Encrypted";
        public Safegaurdkey()
        {
            InitializeComponent();
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = @"C:\Users\ojasd\Desktop\matrix.bat";
            p.Start();
            output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
        }

        private void Safegaurdkey_Load(object sender, EventArgs e)
        {
            _charIndex1 = 0;
            _charIndex1 = 0;
            Thread t = new Thread(new ThreadStart(this.TypewriteText1));
            t.Start();
        }
        private void TypewriteText1()
        {
            while (_charIndex1 < output.Length)
            {
                Thread.Sleep(2);
                tex.Invoke(new Action(() =>
                {
                    tex.Text += output[_charIndex1];
                }));
                _charIndex1++;
            }
            Thread u = new Thread(new ThreadStart(this.TypewriteText2));
            u.Start();
        }
        private void TypewriteText2()
        {
            while (_charIndex2 < check.Length)
            {
                Thread.Sleep(10);
                succ.Invoke(new Action(() =>
                {
                    succ.Text += check[_charIndex2];
                }));
                _charIndex2++;
            }
        }

    }
}
