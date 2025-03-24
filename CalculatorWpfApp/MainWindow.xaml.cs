using System.Windows;

namespace CalculatorWpfApp
{
    public partial class MainWindow : Window
    {
        private string NumberOne;
        private string NumberTwo;
        private string Operation;
        private bool OperationSet;

        public MainWindow()
        {
            InitializeComponent();
            ClearTextBlock();
        }

        public void ClearTextBlock()
        {
            ResultTextBlock.Text = "0";
            NumberOne = "0";
            NumberTwo = "0";
            Operation = null;
            OperationSet = false;
        }

        public void AddNumber(int number)
        {
            if (ResultTextBlock.Text == "0" && !OperationSet)
            {
                ResultTextBlock.Text = number.ToString();
            }
            else if (!OperationSet)
            {
                ResultTextBlock.Text += number.ToString();
            }
            else
            {
                if (ResultTextBlock.Text == "0")
                {
                    ResultTextBlock.Text = number.ToString();
                }
                else
                {
                    ResultTextBlock.Text += number.ToString();
                }
            }
        }

        public void SetOperation(string operation)
        {
            if (OperationSet) return;

            NumberOne = ResultTextBlock.Text;
            Operation = operation;
            OperationSet = true;
            ResultTextBlock.Text = "0";
        }

        public void CalculateResult()
        {
            if (string.IsNullOrEmpty(Operation) || !OperationSet) return;

            NumberTwo = ResultTextBlock.Text;

            try
            {
                double num1 = Convert.ToDouble(NumberOne);
                double num2 = Convert.ToDouble(NumberTwo);
                double result = 0;

                switch (Operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            ResultTextBlock.Text = "На 0 нельзя делить";
                            return;
                        }
                        break;
                }

                ResultTextBlock.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ResultTextBlock.Text = "0";
            }

            OperationSet = false;
            Operation = null;
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearTextBlock();
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            AddNumber(1);
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            AddNumber(2);
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            AddNumber(3);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddNumber(4);
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            AddNumber(5);
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            AddNumber(6);
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            AddNumber(7);
        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            AddNumber(8);
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            AddNumber(9);
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            AddNumber(0);
        }

        private void SummButton_Click(object sender, RoutedEventArgs e)
        {
            SetOperation("+");
        }

        private void SubtractionButton_Click(object sender, RoutedEventArgs e)
        {
            SetOperation("-");
        }

        private void MultiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            SetOperation("*");
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            SetOperation("/");
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            CalculateResult();
        }
    }
}