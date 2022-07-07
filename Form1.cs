using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustAnotherApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            press_01.Visible = true;
            press_02.Visible = false;
        }

        private void press_01_Click(object sender, EventArgs e)
        {
            text_01.Text = "BYE!";
            press_01.Visible = false;
            press_02.Visible = true;
        }

        private void text_01_Click(object sender, EventArgs e)
        {
            press_01.Visible = false;
            press_02.Visible = false;
            text_01.Visible = false;
        }

        private void press_02_Click(object sender, EventArgs e)
        {
            text_01.Text = "HELLO!";
            press_01.Visible = true;
            press_02.Visible = false;
        }
    }
}
