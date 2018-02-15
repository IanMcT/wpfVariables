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

namespace VariableExampleWPF
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

        /// <summary>
        /// Runs when pepperoni is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkPepperoni_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Status of Pepperoni check: " + chkPepperoni.IsChecked.ToString());
        }
        /// <summary>
        /// Runs when button is clicked for the integer entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIntEntry_Click(object sender, RoutedEventArgs e)
        {
            //create an int variable
            int intSomeNumber = 0;
            //TryParse converts to an int, it returns true if it works
            //and false if it doesn't
            int.TryParse(txtIntEntry.Text, out intSomeNumber);
            //testing - does it add?
            intSomeNumber = intSomeNumber + 1;
            //Output the number
            MessageBox.Show(intSomeNumber.ToString());
        }

        /// <summary>
        /// Runs when button is clicked for the Double entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoubleEntry_Click(object sender, RoutedEventArgs e)
        {
            //create a double variable
            double dblSomeNumber = 0.0;
            //TryParse converts to a double, it returns true if it works
            //and false if it doesn't
            double.TryParse(txtDoubleEntry.Text, out dblSomeNumber);
            //testing - does it add?
            dblSomeNumber += 1;
            //Output the number
            MessageBox.Show(dblSomeNumber.ToString());
            //Output and format to 2 decimal places
            MessageBox.Show(dblSomeNumber.ToString("0.00"));
        }

        /// <summary>
        /// Runs when button is clicked for the Char entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCharEntry_Click(object sender, RoutedEventArgs e)
        {
            char chrC = 'a';
            if(txtCharEntry.Text.Length > 0)
            {
                chrC = txtCharEntry.Text[0];
            }
            MessageBox.Show(chrC.ToString());
        }
    }
}
