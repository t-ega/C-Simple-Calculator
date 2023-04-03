namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = Convert.ToString(Calculate('+'));
        }

        double Calculate(char op)
        {
            try
            {
                double op1 = Convert.ToDouble(operand1.Text);
                double op2 = Convert.ToDouble(operand2.Text);
                return op switch
                {
                    '+' => op1 + op2,
                    '-' => op1 - op2,
                    '/' => op1 / op2,
                    '*' => op1 * op2,
                    _ => 0,
                };

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 0;

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = Convert.ToString(Calculate('-'));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = Convert.ToString(Calculate('%'));
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = Convert.ToString(Calculate('*'));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        void UpdateButtons()
        {

            if (operand1.Text != "" && operand2.Text != "")
            {
                btnAdd.Enabled = true;
                btnDivide.Enabled = true;
                btnMultiply.Enabled = true;
                btnSubtract.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnMultiply.Enabled = false;
                btnSubtract.Enabled = false;
            }
        }

        private void operand1_TextChanged(object sender, EventArgs e)
        {

            if (operand1.Text != "")
            {
                UpdateButtons();
            }
        }

        private void operand2_TextChanged(object sender, EventArgs e)
        {
            if (operand1.Text != "")
            {
                UpdateButtons();
            }
        }

        private void operand1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void operand2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}