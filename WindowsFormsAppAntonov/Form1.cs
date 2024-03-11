using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAntonov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = new Button();
            btn.Parent = this;
            btn.Location = new Point(e.X, e.Y);
            btn.Size = new Size(70, 30);
            btn.Text = $"{e.X}; {e.Y}";
            btn.Click += new System.EventHandler(btn_Click);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(sender as Button); 
        }
    }
}
