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
    public partial class splash : Form
    {
        int _charIndex1 = 0;
        int _charIndex2 = 0;
        int _charIndex3 = 0;
        int _charIndex4 = 0;
        int _charIndex5 = 0;
        string output;
        public splash()
        {
            InitializeComponent();
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = @"C:\Users\ojasd\Desktop\ss.bat";
            p.Start();
            output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            _charIndex1 = 0;
            _charIndex2 = 0;
            _charIndex3 = 0;
            _charIndex4 = 0;
            _charIndex5 = 0;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = "         ";
            textBox4.Text = "     ";

            Thread t = new Thread(new ThreadStart(this.TypewriteText1));
            Thread u = new Thread(new ThreadStart(this.TypewriteText2));
            Thread l = new Thread(new ThreadStart(this.loop));
            t.Start();
            u.Start();
            l.Start();

        }

        private void TypewriteText1()
        {
            while (_charIndex1 < output.Length)
            {
                Thread.Sleep(3);
                textBox1.Invoke(new Action(() =>
                {
                    textBox1.Text += output[_charIndex1];
                }));
                _charIndex1++;
            }
        }
        private void safe()
        {
            string ss = "Environment Safe";
            while (_charIndex3 < ss.Length)
            {
                Thread.Sleep(20);
                textBox3.Invoke(new Action(() =>
                {
                    textBox3.Text += ss[_charIndex3];
                }));
                _charIndex3++;
            }
            _charIndex3 = 0;
            Thread gf = new Thread(new ThreadStart(this.enter));
            gf.Start();
        }
        private void enter()
        {
            string sd = "Click Here to Start";
            textBox4.Invoke(new Action(() =>
            {
                textBox4.Text = "         ";
            }));
            while (_charIndex5 < sd.Length)
            {
                Thread.Sleep(20);
                textBox4.Invoke(new Action(() =>
                {
                    textBox4.Text += sd[_charIndex5];
                }));
                _charIndex5++;
            }
            
        }
        private void uxsafe()
        {
            string ss = "Environment Unsafe";
            while (_charIndex4 < ss.Length)
            {
                Thread.Sleep(20);
                textBox3.Invoke(new Action(() =>
                {
                    textBox3.Text += ss[_charIndex4];
                }));
                _charIndex4++;
            }
            _charIndex4 = 0;
            string sd = "The Program will Exit Now.";
            while (_charIndex4 < sd.Length)
            {
                Thread.Sleep(20);
                textBox4.Invoke(new Action(() =>
                {
                    textBox4.Text += sd[_charIndex4];
                }));
                _charIndex4++;
            }
            Thread.Sleep(500);
            System.Environment.Exit(0);

        }
        private void TypewriteText2()
        {
            while (_charIndex2 < output.Length)
            {
                Thread.Sleep(3);
                textBox2.Invoke(new Action(() =>
                {
                    textBox2.Text += output[_charIndex2];
                }));
                _charIndex2++;
            }

        }

        public void loop()
        {
            
            for(int i = 0; i <= 150; i++)
            {
                Thread.Sleep(150);
            }
            if (textBox1.Text.Length == textBox2.Text.Length)
            {
                pictureBox1.Image = ICDEI.Properties.Resources.asdf_good_removebg_preview;
                textBox4.Invoke(new Action(() =>
                {
                    textBox4.Enabled = true;
                }));
                textBox4.ForeColor = System.Drawing.Color.Green;
                Thread f = new Thread(new ThreadStart(this.safe));
                f.Start();
                

            }
            else
            {
                pictureBox1.Image = ICDEI.Properties.Resources.imgonline_com_ua_ReplaceColor_ooc15A6kgeYGre_removebg_preview;
                textBox3.ForeColor = System.Drawing.Color.Red;
                textBox4.Invoke(new Action(() =>
                {
                    textBox4.Enabled = true;
                }));
                
                textBox4.ForeColor = System.Drawing.Color.Red;
                Thread nf = new Thread(new ThreadStart(this.uxsafe));
                nf.Start();
            }
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.SelectionStart = textBox1.Text.Length;
            textBox2.ScrollToCaret();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        
        private void textBox4_Click(object sender, EventArgs e)
        {
            main_ui x = new main_ui();
            x.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
