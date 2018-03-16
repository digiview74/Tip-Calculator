// Henry Hernandez 
// POS/409
// Individual Tip Calculator
// This program is used to calculate the tip amount 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Henry_Hernandez_W1_POS409_Tip_Calculator
{ // Main Form holds all the code and tools to run the program
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        // Number validation
        private void txtAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8; // is backspace
        }
        // Calculates the tip amount and provides a total
        private void button1_Click(object sender, EventArgs e)
        {//declares variables
            double billAmount;
            double totalBill;
            double answer2;
            double answer3;
            double i = 0;
            double t = .0825;
            billAmount = double.Parse(txtAmt.Text);
            // if atatement that allows the user to select default percentage tip rate  
            if (radioButton1.Checked == true)
            {
                i = 0.15;
            }
            else if (radioButton2.Checked == true)
            {
                i = 0.20;
            }
            answer2 = billAmount * t;
            answer3 = billAmount * i;
            totalBill = billAmount + answer2 + answer3;
            // outputs calculation to labelbox
            labelTipAmt.Text = (answer3.ToString());
            labelTotalAmt.Text = (totalBill.ToString("#.##"));
        }
        // resets the Main Form to allow user to reenter data 
        private void button2_Click(object sender, EventArgs e)
        {
            txtAmt.Text = string.Empty;
            labelTipAmt.Text = string.Empty;
            labelTotalAmt.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void button2_Click_2(object sender, EventArgs e)
        {   //Closes application
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {}
        private void txtAmt_TextChanged(object sender, EventArgs e)
        { }
        private void txtTax_TextChanged(object sender, EventArgs e)
        {}
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {}
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {}
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {}
        private void label5_Click(object sender, EventArgs e)
        {}
        private void label4_Click(object sender, EventArgs e)
        {}
        private void button2_Click_1(object sender, EventArgs e)
        {}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {}
        private void labelTotalAmt_Click(object sender, EventArgs e)
        {
        }

        private void labelTipAmt_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
