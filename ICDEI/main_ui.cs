using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICDEI
{
    public partial class main_ui : Form
    {
        public main_ui()
        {
            
            
            InitializeComponent();
        }

        private void main_ui_Load(object sender, EventArgs e)
        {

        }
        private Form active = null;
        private void openform(Form childs)
        {
            if (active != null)
            {
                active.Close();
            }
            active = childs;
            childs.TopLevel = false;
            childs.FormBorderStyle = FormBorderStyle.None;
            childs.Dock = DockStyle.Fill;
            panel1.Controls.Add(childs);
            panel1.Tag = childs;
            childs.BringToFront();
            childs.Show();

        }

        private void safe_Click(object sender, EventArgs e)
        {
            openform(new Safegaurdkey());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openform(new Message());
        }
    }
}
