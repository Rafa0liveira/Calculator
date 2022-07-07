using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        decimal v1 = 0, v2 = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtvisor.Text = txtvisor.Text + "0"; // Could've += instead of repeating txtvisor
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "9";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtvisor.Text += ".";
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            

            if (txtvisor.Text != "" && operation == "Minus")
            {
                txtvisor.Text = Convert.ToString(v1 - v2);
            } else if (txtvisor.Text != "" && operation == "Mult")
            {
                v2 = decimal.Parse(txtvisor.Text, CultureInfo.InvariantCulture);
                txtvisor.Text = Convert.ToString(v1 * v2);
            } else if (txtvisor.Text != "" && operation == "Div")
            {
                v2 = decimal.Parse(txtvisor.Text, CultureInfo.InvariantCulture);
                txtvisor.Text = Convert.ToString(v1 / v2);
            } else if (txtvisor.Text != "" && operation == "Add")
            {
                v2 = decimal.Parse(txtvisor.Text, CultureInfo.InvariantCulture);
                txtvisor.Text = Convert.ToString(v1 + v2);
            } else            
            {
              MessageBox.Show("Please enter a value to be calculated.", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnminus_Click(object sender, EventArgs e)
        {

            if (txtvisor.Text != "")

            {
                v1 = decimal.Parse(txtvisor.Text, CultureInfo.InvariantCulture);
                txtvisor.Text = "";
                operation = "Minus";
                lblop.Text = "-";
            }
            else
            {
                MessageBox.Show("Please enter a value to be calculated.", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            private void btndiv_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text != "")

            { v1 = decimal.Parse(txtvisor.Text, CultureInfo.InvariantCulture);
            txtvisor.Text = "";
            operation = "Div";
            lblop.Text = "/";
        }   else
            {
             MessageBox.Show("Please enter a value to be calculated.", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void btnmult_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text != "")
            {
            v1 = decimal.Parse(txtvisor.Text, CultureInfo.InvariantCulture);
            txtvisor.Text = "";
            operation = "Mult";
            lblop.Text = "x";
            }
            else
            {
             MessageBox.Show("Please enter a value to be calculated.", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtvisor.Text = "";
            lblop.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtvisor.Text = "";
            
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text != "")
            {
                v1 = decimal.Parse(txtvisor.Text, CultureInfo.InvariantCulture);
                txtvisor.Text = "";
                operation = "Add";
                lblop.Text = "+";
            }else
            {
                MessageBox.Show("Please enter a value to be calculated.", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
