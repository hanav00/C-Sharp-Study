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
            numScreen.Text += "×";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            numScreen.Text += "÷";
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

        //계산
        private void equal_Click(object sender, EventArgs e)
        {
            string input = numScreen.Text;

            //숫자와 연산기호를 분리해서 list에 담기
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
                // 에러 메시지를 출력하거나 다른 처리를 하고 싶다면 이 부분을 수정하세요.
                numScreen.Text = "ERROR";
                return;
            }

            //배열로 변환
            string[] expressionsArray = expressions.ToArray();

            // 곱하기 나누기 계산
            for (int i = 0; i < expressionsArray.Length; i++)
            {
                if (expressionsArray[i] == "×")
                {
                    double calculated = Convert.ToDouble(expressionsArray[i - 1]) * Convert.ToDouble(expressionsArray[i + 1]);
                    //새로운 배열 만들어서 다시 진행
                    expressionsArray[i - 1] = calculated.ToString();
                    //현재 "×" 연산을 처리한 결과를 이전 인덱스에 저장하고
                    //다음 인덱스부터 이후의 요소들을 한 칸씩 앞으로 당김
                    for (int j = i; j < expressionsArray.Length - 2; j++)
                    {
                        expressionsArray[j] = expressionsArray[j + 2];
                    }
                    //배열의 길이가 2 줄었으므로 배열의 마지막 두 요소를 제거
                    Array.Resize(ref expressionsArray, expressionsArray.Length - 2);
                    i -= 2; // 다음 순회에서 현재 처리한 "×" 연산을 제외하고 이어서 진행하도록 인덱스 조정
                }

                else if (expressionsArray[i] == "÷")
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

            //더하기 빼기 계산
            double result = 0;

            // 맨 앞에 "+"나 "-"가 있는 경우 처리
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

            //결과 출력
            numScreen.Text = Convert.ToString(result);

        }

        //연산 유효성 검사
        public static bool ContainsInvalidOperators(List<string> expressions)
        {
            foreach (string expression in expressions)
            {
                Console.WriteLine(expression);
            }
            
            HashSet<string> validOperators = new HashSet<string> { "+", "-", "×", "÷" };
            
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