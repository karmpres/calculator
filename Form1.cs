using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing
{
    public partial class Calculator : Form
    {
        double result_input = 0;
        //double result_input2 = 0;
        string operandCommand = "";
        bool isOperandUsed = false;
        
        public Calculator()
        {
            InitializeComponent();
        }

       

        private void btn_click(object sender, EventArgs e)
        {
            if ((txtbox_out.Text == "0") || (isOperandUsed))
            {
                txtbox_out.Clear();
            }
            isOperandUsed = false;

            Button button = (Button)sender;
            txtbox_out.Text = txtbox_out.Text + button.Text;
            lbltxt_result.Text = lbltxt_result.Text + button.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
           
            Button button = (Button)sender;
            operandCommand = button.Text;
            result_input = Double.Parse(txtbox_out.Text);

            // isOperandUsed = true;
            lbltxt_result.Text = lbltxt_result.Text + button.Text;
            isOperandUsed = true;


        }
        public void add(double a, double b)
        {
            double value = a + b;
        }

        public void sub(double a, double b)
        {
            double value = a - b;
        }

        private void operator_result(object sender, EventArgs e)
        {
            switch (operandCommand)
            {
                case "+":
                    txtbox_out.Text = (result_input + Double.Parse(txtbox_out.Text)).ToString();
                    break;

                case "-":
                    txtbox_out.Text = (result_input - Double.Parse(txtbox_out.Text)).ToString();
                    break;

            }

        }
    

        private void btn_clear1(object sender, EventArgs e)
        {
            txtbox_out.Text = "0";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtbox_out.Text = "0";
            result_input = 0;
        }

        private void lbltxt_result_Click(object sender, EventArgs e)
        {

        }
    }
}
