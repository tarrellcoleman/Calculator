using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        Boolean pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_Button(object sender, EventArgs e)
        {
            if((res.Text == "0")||(pressed))
            {
                res.Clear();
            }
            pressed = false;
            Button b = (Button)sender;
            if(b.Text ==".")
            {
                if(!res.Text.Contains("."))
                {
                    res.Text = res.Text + b.Text;
                }
            }
            else
            {
                res.Text = res.Text + b.Text;
            }
            
        }

        private void CE_Click(object sender, EventArgs e)
        {
            res.Text = "0";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                equals.PerformClick();
                pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(res.Text);
                pressed = true;
                equation.Text = value + " " + operation;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    res.Text = (value + Double.Parse(res.Text)).ToString();
                    break;
                case "-":
                    res.Text = (value - Double.Parse(res.Text)).ToString();
                    break;
                case "*":
                    res.Text = (value * Double.Parse(res.Text)).ToString();
                    break;
                case "/":
                    res.Text = (value / Double.Parse(res.Text)).ToString();
                    break;
                
            }
            value = Int32.Parse(res.Text);
            operation = string.Empty;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            res.Text = "0";
            equation.Text = "";
            value = 0;
        }

    }
}
