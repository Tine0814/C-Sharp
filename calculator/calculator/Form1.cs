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
        private double value;
        private string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperationClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var newValue = double.Parse(txtNumber.Text);

            switch (btn.Text)
            {
                case "*":
                case "/":
                case "+":
                case "-":

                    value = newValue;
                    op = btn.Text;
                    txtNumber.Text = "0";
                    break;
                case "=":
                    switch(op)
                    {
                        case "*": value *= newValue; break;
                        case "/": value /= newValue; break;
                        case "+": value += newValue; break;
                        case "-": value -= newValue; break;
                    }
                    txtNumber.Text =$"{ value:0.###}";
                    break;
                case "AC":
                    value = 0;
                    op = "";
                    txtNumber.Text = "0";
                    break;
                case "+/-": txtNumber.Text = $"{-newValue:0.###}"; break;
                case "%":txtNumber.Text = $"{(newValue / 100):0.###}"; break;
                case ".":
                    if (!txtNumber.Text.Contains("."))
                        txtNumber.Text = $"{txtNumber.Text}.";
                    break;
            }
        }

        private void btnNumberClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (txtNumber.Text == "0")
                txtNumber.Text = btn.Text;
            else
                txtNumber.Text = $"{txtNumber.Text}{btn.Text}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
