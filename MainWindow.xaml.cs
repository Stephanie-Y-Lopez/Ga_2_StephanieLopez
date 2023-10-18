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

namespace Ga_2_StephanieLopez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object lblEquation;

        public MainWindow()
        {
            InitializeComponent();
        } // MainWindow()

        private void btnFullName_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string fullName = $"{firstName} {lastName}";

            //Display full name on button click
            MessageBox.Show(fullName);

        } //btnFullName_Click

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            // For readability I decided to add a sign and equal variable
            string sign = "+";
            string equalSign = "=";
            string result = number1 + number2;
            // I use a string literal to make it easier to format my equation with lots of variables
            string equation = $"{number1} {sign} {number2} {equalSign} {result}";
            
            // Displaying the equation string
            bblEquation.Content = equation;
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
