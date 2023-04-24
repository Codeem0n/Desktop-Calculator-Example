using System;
using System.Collections.Generic;
using System.Data;
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

namespace DesktopCalculator
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


        public string EquationString = "";

        private void Equation_Click(object sender, RoutedEventArgs e)
        {

            Button buttonThatWasClicked = (Button)sender;
            EquationString = EquationString + buttonThatWasClicked.Content; // ""+"1+1" ="1+1"

            EquationTextBox.Text = EquationString;

        }

        private void uxPowerOfTwoBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                DataTable dataTable = new DataTable();

                double answer = Convert.ToDouble(dataTable.Compute(EquationString, ""));

                answer = answer * answer;

                EquationString = answer.ToString();


            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message.ToString());
            }
        }

        private void uxClearBTN_Click(object sender, RoutedEventArgs e)
        {
            EquationString = "";
            EquationTextBox.Text = EquationString;

            //Clearing out our work
        }

        private void uxEqualBTN_Click(object sender, RoutedEventArgs e)
        {


            try
            {

                DataTable dataTable = new DataTable();

                double answer = Convert.ToDouble(dataTable.Compute(EquationString, ""));

                double x = Convert.ToDouble(EquationString);
                EquationString = answer.ToString();

                EquationTextBox.Text = EquationString;


            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message.ToString());
            }

        }

    }
}
