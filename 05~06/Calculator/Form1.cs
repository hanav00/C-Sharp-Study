using System.Collections;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            numScreen.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            numScreen.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            numScreen.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            numScreen.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            numScreen.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            numScreen.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            numScreen.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            numScreen.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            numScreen.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            numScreen.Text += "0";
        }

        private void add_Click(object sender, EventArgs e)
        {
            numScreen.Text += "+";
        }

        private void substract_Click(object sender, EventArgs e)
        {
            numScreen.Text += "-";
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            numScreen.Text += "��";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            numScreen.Text += "��";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            numScreen.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string currentText = numScreen.Text;

            if (!string.IsNullOrEmpty(currentText))
            {
                int length = currentText.Length;
                numScreen.Text = currentText.Substring(0, length - 1);
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (numScreen.Text.Length == 0)
            {
                numScreen.Text += ".";
            }
            else if (numScreen.Text.Length > 0 && numScreen.Text.Substring(numScreen.Text.Length-1, 1) == ".")
            {
                numScreen.Text += "";
            } 
            else
            {
                numScreen.Text += ".";
            }
            
        }

        //���
        private void equal_Click(object sender, EventArgs e)
        {
            string input = numScreen.Text;

            //���ڿ� �����ȣ�� �и��ؼ� list�� ���
            List<string> expressions = new List<string>();
            string currentExpression = "";

            foreach (char ch in input)
            {
                if (char.IsDigit(ch) || ch == '.')
                {
                    currentExpression += ch;
                }
                else
                {
                    if (!string.IsNullOrEmpty(currentExpression))
                    {
                        expressions.Add(currentExpression);
                        currentExpression = "";
                    }

                    expressions.Add(ch.ToString());
                }
            }

            if (!string.IsNullOrEmpty(currentExpression))
            {
                expressions.Add(currentExpression);
            }


            if (ContainsInvalidOperators(expressions))
            {
                Console.WriteLine("Invalid operators in the input expression.");
                // ���� �޽����� ����ϰų� �ٸ� ó���� �ϰ� �ʹٸ� �� �κ��� �����ϼ���.
                numScreen.Text = "ERROR";
                return;
            }

            //�迭�� ��ȯ
            string[] expressionsArray = expressions.ToArray();

            // ���ϱ� ������ ���
            for (int i = 0; i < expressionsArray.Length; i++)
            {
                if (expressionsArray[i] == "��")
                {
                    double calculated = Convert.ToDouble(expressionsArray[i - 1]) * Convert.ToDouble(expressionsArray[i + 1]);
                    //���ο� �迭 ���� �ٽ� ����
                    expressionsArray[i - 1] = calculated.ToString();
                    //���� "��" ������ ó���� ����� ���� �ε����� �����ϰ�
                    //���� �ε������� ������ ��ҵ��� �� ĭ�� ������ ���
                    for (int j = i; j < expressionsArray.Length - 2; j++)
                    {
                        expressionsArray[j] = expressionsArray[j + 2];
                    }
                    //�迭�� ���̰� 2 �پ����Ƿ� �迭�� ������ �� ��Ҹ� ����
                    Array.Resize(ref expressionsArray, expressionsArray.Length - 2);
                    i -= 2; // ���� ��ȸ���� ���� ó���� "��" ������ �����ϰ� �̾ �����ϵ��� �ε��� ����
                }

                else if (expressionsArray[i] == "��")
                {
                    double calculated = Convert.ToDouble(expressionsArray[i - 1]) / Convert.ToDouble(expressionsArray[i + 1]);
                    expressionsArray[i - 1] = calculated.ToString();
                    for (int j = i; j < expressionsArray.Length - 2; j++)
                    {
                        expressionsArray[j] = expressionsArray[j + 2];
                    }
                    Array.Resize(ref expressionsArray, expressionsArray.Length - 2);
                    i -= 2;
                }
            }

            //���ϱ� ���� ���
            double result = 0;

            // �� �տ� "+"�� "-"�� �ִ� ��� ó��
            if (expressionsArray[0] == "+")
            {
                result = Convert.ToDouble(expressionsArray[1]);
            }
            else if (expressionsArray[0] == "-")
            {
                result = -Convert.ToDouble(expressionsArray[1]);
            }
            else
            {
                result = Convert.ToDouble(expressionsArray[0]);
            }

            for (int i = 1; i < expressionsArray.Length; i++)
            {
                if (expressionsArray[i] == "+")
                {
                    result += Convert.ToDouble(expressionsArray[i + 1]);
                }
                if (expressionsArray[i] == "-")
                {
                    result -= Convert.ToDouble(expressionsArray[i + 1]);
                }
            }

            //��� ���
            numScreen.Text = Convert.ToString(result);

        }

        //���� ��ȿ�� �˻�
        public static bool ContainsInvalidOperators(List<string> expressions)
        {
            foreach (string expression in expressions)
            {
                Console.WriteLine(expression);
            }
            
            HashSet<string> validOperators = new HashSet<string> { "+", "-", "��", "��" };
            
            if (expressions[0] == "+" || expressions[0] =="-")
            {
                for (int i = 0; i < expressions.Count; i += 2)
                {
                    if (!validOperators.Contains(expressions[i]))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                for (int i = 1; i < expressions.Count; i += 2)
                {
                    if (!validOperators.Contains(expressions[i]))
                    {
                        return true;
                    }
                }
                return false;
            }
            
        }
    }
}