using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResultText.Text= string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = string.Empty;
            var button = sender as Button;
            var currentNumber = button.Name[button.Name.Length-1];
            CurrentOperationText.Text+= currentNumber;
        }

        
        private void ButonAdd_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }

            CurrentOperationText.Text += "+";
        }

        private void ButonMinus_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }
            CurrentOperationText.Text += "-";
        }

        private void ButonMultiply_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }
            CurrentOperationText.Text += "*";
        }

        private void ButonDivide_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = CalculateResult(operation).ToString();
            }
            CurrentOperationText.Text += "/";
        }

        private void ButonResult_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;


            ResultText.Text = CalculateResult(operation).ToString();

            CurrentOperationText.Text = string.Empty;

        }
        private bool ContainsOperation(string operation)
            => operation.Contains("-") || operation.Contains("+") || operation.Contains("*") || operation.Contains("/");
        
        private int CalculateResult(string operation)
        {
            if (operation.Contains("+"))
            {
                var addElements = operation.Split('+');
                return int.Parse(addElements[0]) + int.Parse(addElements[1]);
            }
            if (operation.Contains("-"))
            {
                var addElements = operation.Split('-');
                return int.Parse(addElements[0]) - int.Parse(addElements[1]);
            }
            if (operation.Contains("*"))
            {
                var addElements = operation.Split('*');
                return int.Parse(addElements[0]) * int.Parse(addElements[1]);
            }
            if (operation.Contains("/"))
            {
                var addElements = operation.Split('/');
                return int.Parse(addElements[0]) / int.Parse(addElements[1]);
            }
            return default;
        }
    }
}
