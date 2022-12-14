using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
//ctr+r+g usuwa niepotrzebne rzeczy

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int counter;
        public bool IsPlayer1Turn { get; set; } = true;
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        public void NewGame()
        {
            IsPlayer1Turn = false;
            counter = 0;
            Button_0_0.Content = string.Empty;
            Button_0_1.Content = string.Empty;
            Button_0_2.Content = string.Empty;
            Button_1_0.Content = string.Empty;
            Button_1_1.Content = string.Empty;
            Button_1_2.Content = string.Empty;
            Button_2_0.Content = string.Empty;
            Button_2_1.Content = string.Empty;
            Button_2_2.Content = string.Empty;

            Button_0_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsPlayer1Turn ^= true;
            counter++;
            if (counter > 9)
            {
                NewGame();
                return;
            }
            var button = sender as Button;
            button.Content = IsPlayer1Turn ? "O" : "X";

            if (CheckIfPlayerWon())
            {
                counter = 9;
            }
        }
        private bool CheckIfPlayerWon()
        {
            //Column0
            if (Button_0_0.Content != string.Empty && Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_0_1.Background = Brushes.Green;
                Button_0_2.Background = Brushes.Green;
                return true;
            }
            //Column1
            if (Button_1_0.Content != string.Empty && Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                return true;
            }
            //Column2
            if (Button_2_0.Content != string.Empty && Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }

            // Row0
            if (Button_0_0.Content != string.Empty && Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_0.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;
            }
            // Row1
            if (Button_0_1.Content != string.Empty && Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                return true;
            }
            // Row2
            if (Button_0_2.Content != string.Empty && Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }

            //
            if (Button_0_0.Content != string.Empty && Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }
            if (Button_0_2.Content != string.Empty && Button_0_2.Content == Button_1_1.Content && Button_1_1.Content == Button_2_0.Content)
            {
                Button_2_2.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;
            }
            return false;
        }
    }
}
