using System;
using System.Windows.Forms;

namespace RadioButtonsinActionPrjt
{
    public partial class frmRadioStar : Form
    {
        public frmRadioStar()
        {
            InitializeComponent();
            btnCalculate.Click += BtnCalculate_Click;
            btnReset.Click += BtnReset_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLeftInput.Text, out double left) ||
                !double.TryParse(txtRightInput.Text, out double right))
            {
                lblMessage.Text = "Please enter valid numbers.";
                return;
            }

            double result = 0;
            string equation = "";
            if (rdoAdd.Checked)
            {
                result = left + right;
                equation = $"{left} + {right} = {result}";
            }
            else if (rdoSubtract.Checked)
            {
                result = left - right;
                equation = $"{left} - {right} = {result}";
            }
            else if (rdoMultiply.Checked)
            {
                result = left * right;
                equation = $"{left} * {right} = {result}";
            }
            else if (rdoDivide.Checked)
            {
                if (right == 0)
                {
                    lblMessage.Text = "Cannot divide by zero.";
                    return;
                }
                result = Math.Round(left / right, 2);
                equation = $"{left} / {right} = {result:F2}";
            }
            else if (rdoModulus.Checked)
            {
                if (right == 0)
                {
                    lblMessage.Text = "Cannot perform modulus by zero.";
                    return;
                }
                result = left % right;
                equation = $"{left} % {right} = {result}";
            }
            else
            {
                lblMessage.Text = "Please select an operation.";
                return;
            }

            if (chkVerbose.Checked)
                lblMessage.Text = equation;
            else
                lblMessage.Text = $"The answer is: {result:F2}";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtLeftInput.Text = "";
            txtRightInput.Text = "";
            lblMessage.Text = "";
            rdoAdd.Checked = false;
            rdoSubtract.Checked = false;
            rdoMultiply.Checked = false;
            rdoDivide.Checked = false;
            rdoModulus.Checked = false;
            chkVerbose.Checked = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
