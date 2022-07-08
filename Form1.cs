using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            button2.Visible = false;
            textBox1.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            text_01.Text = "PRETTY SWAG!";
        }

        private void save_me_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            textBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            textBox1.Visible = false;
            string name;
            name = textBox1.Text;
            File.Create(name + ".txt");
            Console.WriteLine("Saved " + name + ".txt lol.");
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
