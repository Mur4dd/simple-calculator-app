namespace Day_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void proscessButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            int number1 = Convert.ToInt32(number1MaskedBox.Text);
            int number2 = Convert.ToInt32(number2MaskedBox.Text);
            string selectedOperator = Convert.ToString(operatorComboBox.Text);

            if (selectedOperator == "+")
            {
                result = number1 + number2;
            }
            else if (selectedOperator == "-")
            {
                result = number1 - number2;
            }
            else if (selectedOperator == "*")
            {
                result = number1 * number2;
            }
            else if (selectedOperator == "/")
            {
                result = number1 / number2;
            }
            else
            {
                MessageBox.Show("Check an Operant", "- Info -");
            }

            resultListBox.Items.Add(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form is Building ...", "- Info -" );
        }
    }
}
