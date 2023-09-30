namespace Calculator
{
    public partial class Form1 : Form
    {
        string operand = "";
        double first, fnum;

        bool isOperandPressed = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string btext = button.Text;
            if (btext == "C")
            {
                textBox1.Text = "";
                label2.Text = "";

            }
            else if (btext == "CE")
            {
                if (!(textBox1.Text == ""))
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
                }
            }
            else if (btext == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += ".";
                    label2.Text += ".";
                }

            }
            else if (btext == "=")
            {
                double second = Double.Parse(textBox1.Text);
                double result = 0.0;
                switch (operand)
                {
                    case "+":
                        result = fnum + second;
                        break;
                    case "-":
                        result = fnum - second;
                        break;
                    case "*":
                        result = fnum * second;
                        break;
                    case "/":
                        result = fnum / second;
                        break;
                    case "%":
                        result = fnum % second;
                        break;
                    default:
                        return;
                }
                textBox1.Text = result.ToString();
                label2.Text += "=";
            }
            else if (IsNumber(btext))
            {
                label2.Text += btext;
                if (isOperandPressed)
                {
                    textBox1.Clear();
                    fnum = first;
                    isOperandPressed = false;
                }


                textBox1.Text += btext;
                first = Double.Parse(textBox1.Text);

            }
            else if (IsOperand(btext))
            {
                operand = btext;
                label2.Text += operand;
                isOperandPressed = true;
            }
        }
        private bool IsNumber(string btext)
        {
            return Double.TryParse(btext, out _);
        }
        private bool IsOperand(string input)
        {
            return input == "+" || input == "-" || input == "*" || input == "/" || input == "%";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button13_Click(object sender, EventArgs e) => Button_Click(sender, e);

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

             => Button_Click(sender, e);


        private void button6_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void button10_Click(object sender, EventArgs e) => Button_Click(sender, e);

        private void button1_Click(object sender, EventArgs e) => Button_Click(sender, e);

        private void button5_Click(object sender, EventArgs e) => Button_Click(sender, e);

        private void button9_Click(object sender, EventArgs e) => Button_Click(sender, e);

        private void button14_Click(object sender, EventArgs e) => Button_Click(sender, e);

        private void button15_Click(object sender, EventArgs e) => Button_Click(sender, e);

        private void button16_Click(object sender, EventArgs e) => Button_Click(sender, e);

        private void button19_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void button18_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void button17_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void button12_Click(object sender, EventArgs e) => Button_Click(sender, e);

        private void button11_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void button7_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void button8_Click(object sender, EventArgs e) => Button_Click(sender, e);

        private void button4_Click(object sender, EventArgs e) => Button_Click(sender, e);

        private void button3_Click(object sender, EventArgs e) => Button_Click(sender, e);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}