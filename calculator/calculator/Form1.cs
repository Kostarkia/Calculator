using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        bool oparetor = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Rakam(object sender, EventArgs e)
        {
            if (snc.Text == "0" || oparetor)
                snc.Clear();

            oparetor = false;
            Button btn = (Button)sender;
            snc.Text += btn.Text;
        }

        private void operator1(object sender, EventArgs e)
        {
            oparetor = true;
            Button btn = (Button)sender;
            string newOpt = btn.Text;
            
            lb.Text = lb.Text + " " + snc.Text + " " + newOpt;
            switch (opt)
            {
                case "+": snc.Text = (sonuc + Double.Parse(snc.Text)).ToString(); break;
                case "-": snc.Text = (sonuc - Double.Parse(snc.Text)).ToString(); break;
                case "*": snc.Text = (sonuc * Double.Parse(snc.Text)).ToString(); break;
                case "/": snc.Text = (sonuc / Double.Parse(snc.Text)).ToString(); break;
            }
            sonuc = Double.Parse(snc.Text);
            snc.Text = sonuc.ToString();
            opt = newOpt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            snc.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            snc.Text = "0";
            lb.Text = "";
            opt = "";
            sonuc = 0;
            oparetor = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lb.Text = "";
            oparetor = true;
            switch (opt)
            {
                case "+": snc.Text = (sonuc + Double.Parse(snc.Text)).ToString(); break;
                case "-": snc.Text = (sonuc - Double.Parse(snc.Text)).ToString(); break;
                case "*": snc.Text = (sonuc * Double.Parse(snc.Text)).ToString(); break;
                case "/": snc.Text = (sonuc / Double.Parse(snc.Text)).ToString(); break;
            }
            sonuc = Double.Parse(snc.Text);
            snc.Text = sonuc.ToString();
            opt = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (snc.Text == "0")
            {
                snc.Text = "0";
            }
            else if (oparetor)
            {
                snc.Text = "0";
            }

            if (!snc.Text.Contains(","))
            {
                snc.Text += ",";
            }
            oparetor = false;
        }
    }
}
