namespace HelloWorldWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello C#!";
        }

        //연산기호 dropdown
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] operators = { "+", "-", "*", "/"};
            operator1.Items.AddRange(operators);
            operator1.SelectedIndex = 0;
        }

        private void sumNums_Click(object sender, EventArgs e)
        {
            //예외처리
            if (String.IsNullOrWhiteSpace(sum1.Text) || String.IsNullOrWhiteSpace(sum2.Text))
            {
                MessageBox.Show("숫자를 입력해주세요");
                return;
            }
            if (!double.TryParse(sum1.Text, out double number1) || !double.TryParse(sum2.Text, out double number2))
            {
                MessageBox.Show("숫자가 아닌 값이 입력되었습니다. 숫자를 입력해주세요");
                return;
            }


            double num1 = Convert.ToDouble(sum1.Text);
            double num2 = Convert.ToDouble(sum2.Text);
            string selectedOperator = operator1.Text;

            if (selectedOperator == "+") 
            { 
                sumResult.Text = Convert.ToString(Add(num1, num2)); 
            }

            if (selectedOperator == "-")
            {
                sumResult.Text = Convert.ToString(Sub(num1, num2));
            }

            if (selectedOperator == "*")
            {
                sumResult.Text = Convert.ToString(Mul(num1, num2));
            }

            if (selectedOperator == "/")
            {
                sumResult.Text = Convert.ToString(Div(num1, num2));
            }

        }

        double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return Math.Round(result, 10);
        }
        double Sub(double num1, double num2)
        {
            double result = num1 - num2;
            return Math.Round(result, 10);
        }
        double Mul(double num1, double num2)
        {
            double result = num1 * num2;
            return Math.Round(result, 10);
        }
        double Div(double num1, double num2)
        {
            double result = num1 / num2;
            return Math.Round(result, 10);
        }


    }
}