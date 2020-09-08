using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Simple_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonAddition_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total=0;

            number1 = Convert.ToDouble(textBoxAnswer1.Text);

            number2 = Convert.ToDouble(textBoxAnswer2.Text);


            total = number1 + number2;

            label1.Content = total;
        }

        private void buttonModulus_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBoxAnswer1.Text);

            number2 = Convert.ToDouble(textBoxAnswer2.Text);

            total = number1 % number2;

            label1.Content = total;

        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBoxAnswer1.Text);

            number2 = Convert.ToDouble(textBoxAnswer2.Text);

            total = number1 - number2;

            label1.Content = total;
        }

        private void buttonDivision_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBoxAnswer1.Text);

            number2 = Convert.ToDouble(textBoxAnswer2.Text);

            total = number1 / number2;

            label1.Content = total;
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBoxAnswer1.Text);

            number2 = Convert.ToDouble(textBoxAnswer2.Text);

            total = number1 * number2;

            label1.Content = total;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = " ";

            textBoxAnswer1.Text = " ";

            textBoxAnswer2.Text = " ";

        }
    }
}
