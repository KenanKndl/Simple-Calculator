namespace OOP_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
            double result = firstNumber + secondNumber;
            txtResult.Text = Convert.ToString(result);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
            double result = firstNumber - secondNumber;
            txtResult.Text = Convert.ToString(result);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
            double result = firstNumber * secondNumber;
            txtResult.Text = Convert.ToString(result);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
            double result = firstNumber / secondNumber;
            txtResult.Text = Convert.ToString(result);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();
            txtResult.BackColor = Color.FromArgb(98, 114, 164);
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(txtResult.Text);
            if (result > 0)
            {
                txtResult.BackColor = Color.FromArgb(80, 250, 123);
            }
            else
            {
                txtResult.BackColor = Color.FromArgb(255, 85, 85);
            }
        }


        // MOUSE ENTER AND LEAVE FUNCTIONS
        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.FromArgb(255, 85, 85);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.FromArgb(80, 250, 123);
        }

        private void btnSubtract_MouseEnter(object sender, EventArgs e)
        {
            btnSubtract.ForeColor = Color.FromArgb(255, 85, 85);
        }

        private void btnSubtract_MouseLeave(object sender, EventArgs e)
        {
            btnSubtract.ForeColor = Color.FromArgb(80, 250, 123);
        }

        private void btnMultiply_MouseEnter(object sender, EventArgs e)
        {
            btnMultiply.ForeColor = Color.FromArgb(255, 85, 85);
        }

        private void btnMultiply_MouseLeave(object sender, EventArgs e)
        {
            btnMultiply.ForeColor = Color.FromArgb(80, 250, 123);
        }

        private void btnDivide_MouseEnter(object sender, EventArgs e)
        {
            btnDivide.ForeColor = Color.FromArgb(255, 85, 85);
        }

        private void btnDivide_MouseLeave(object sender, EventArgs e)
        {
            btnDivide.ForeColor = Color.FromArgb(80, 250, 123);
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.FromArgb(255, 85, 85);
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.FromArgb(80, 250, 123);
        }

        private void txtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Please enter a valid number.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Handled = true;
            }
        }

        private void txtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Please enter a valid number.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Handled = true;
            }
        }
    }
}
