using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        mkalkulator kalkulator = new mkalkulator();

        private static Form2 frm2;
        Form2 ce = new Form2();

        private static Form3 frm3;
        Form3 ci = new Form3();

        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "";
        }

        private void butn1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "1";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "8";
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "0";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            kalkulator.angka1 = (double.Parse(textBox2.Text));
            textBox2.Text = "";
            kalkulator.pilihan = "/";
        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            kalkulator.angka1 = (double.Parse(textBox2.Text));
            textBox2.Text = "";
            kalkulator.pilihan = "*";
        }
        private void button15_Click_1(object sender, EventArgs e)
        {
            kalkulator.angka1 = double.Parse(textBox2.Text);
            textBox2.Text = "";
            kalkulator.pilihan = "+";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            kalkulator.angka1 = (double.Parse(textBox2.Text));
            textBox2.Text = "";
            kalkulator.pilihan = "-";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kalkulator.angka2 = Double.Parse(textBox2.Text);
            textBox2.Text = kalkulator.getHasil().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void akar_Click(object sender, EventArgs e)
        {
            kalkulator.angka1 = (double.Parse(textBox2.Text));
            textBox2.Text = "";
            kalkulator.pilihan = "√";
        }

        private void pangkat2_Click(object sender, EventArgs e)
        {
            kalkulator.angka1 = (double.Parse(textBox2.Text));
            textBox2.Text = "";
            kalkulator.pilihan = "^";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 496;
            
        }

        private void howAboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ce.Show();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ci.Show();
        }

        private void advanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}