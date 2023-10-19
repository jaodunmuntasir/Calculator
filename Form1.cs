namespace Calculator3
{
    public partial class calculator : Form
    {
        private string input = string.Empty;
        private string operand1 = "0";
        private string operation;
        private double result = 0.0;
        private string operand2 = string.Empty;

        public calculator()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            screen.Text = input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Text == "=")
            {
                switch (operation)
                {
                    case "+":
                        result = double.Parse(operand1) + double.Parse(input);
                        signbox.Text = "=";
                        break;
                    case "-":
                        result = double.Parse(operand1) - double.Parse(input);
                        signbox.Text = "=";
                        break;
                    case "*":
                        result = double.Parse(operand1) * double.Parse(input);
                        signbox.Text = "=";
                        break;
                    case "/":
                        result = double.Parse(operand1) / double.Parse(input);
                        signbox.Text = "=";
                        break;
                }
                
                input = result.ToString();
                screen.Text = input;
                operand1 = "0";
            }
            else if (b.Text == "+" || b.Text == "-" || b.Text == "*" || b.Text == "/")
            {
                signbox.Text = b.Text;
                if (operand1 != "0")
                {
                    switch (operand2)
                    {
                        case "+":
                            result = double.Parse(operand1) + double.Parse(input);
                            break;
                        case "-":
                            result = double.Parse(operand1) - double.Parse(input);
                            break;
                        case "*":
                            result = double.Parse(operand1) * double.Parse(input);
                            break;
                        case "/":
                            result = double.Parse(operand1) / double.Parse(input);
                            break;
                    }

                    operand1 = result.ToString();
                    input = string.Empty;
                    screen.Text = result.ToString();
                }
                else
                {
                    operand1 = input;
                    input = string.Empty;
                }

                operation = b.Text;
                operand2 = operation;
            }
            else
            {
                input += b.Text;
                screen.Text = input;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            input = string.Empty;
            operand1 = "0";
            result = 0.0;
            operand2 = string.Empty;
            signbox.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (input.Length > 0)
            {
                input = input.Remove(input.Length - 1);
                screen.Text = input;
            }
        }
    }
}