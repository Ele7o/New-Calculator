using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        private double a, b;
        private Calculation c;
        public Form()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            a = double.Parse(numOne.Text);
            b = double.Parse(numTwo.Text);
            c = new Calculation(a,b);


            numOne.Text = c.Execute("+").ToString();
            numTwo.Clear();
            pastCal.Text = a.ToString() + " + " + b.ToString();
            labelOne.Text = "Kết quả";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            a = double.Parse(numOne.Text);
            b = double.Parse(numTwo.Text);
            c = new Calculation(a, b);


            numOne.Text = c.Execute("-").ToString();
            numTwo.Clear();
            pastCal.Text = a.ToString() + " - " + b.ToString();
            labelOne.Text = "Kết quả";
        }

        private void numTwo_TextChanged(object sender, EventArgs e)
        {
            labelOne.Text= "Số thứ nhất";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            a = double.Parse(numOne.Text);
            b = double.Parse(numTwo.Text);
            c = new Calculation(a, b);


            numOne.Text = c.Execute("*").ToString();
            numTwo.Clear();
            pastCal.Text = a.ToString() + " X " + b.ToString();
            labelOne.Text = "Kết quả";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            a = double.Parse(numOne.Text);
            b = double.Parse(numTwo.Text);
            if (b != 0)
            {
                c = new Calculation(a, b);
                numOne.Text = c.Execute("÷").ToString();
                numTwo.Clear();
                pastCal.Text = a.ToString() + " ÷ " + b.ToString();
                labelOne.Text = "Kết quả";
            }
            else
            {
                
            }

            
        }
    }
}
