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

namespace WPFSimpleCalcutatorRH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _Units;

        public MainWindow()
        {
            InitializeComponent();
            InitializeWindowElement();
        }

        private void InitializeWindowElement()
        {
            _Units = "Parsecs";

            


            UpdateUnits();
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Help_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpwindow = new HelpWindow();

            helpwindow.ShowDialog();

        }

        private void Button_Calculate_Click_1(object sender, RoutedEventArgs e)
        {
            
            double v;
            double sqrt;
            double square;
            double cube;
            

            square = double.Parse(TextBox_Number.Text) * double.Parse(TextBox_Number.Text);

            cube = double.Parse(TextBox_Number.Text) * double.Parse(TextBox_Number.Text) * double.Parse(TextBox_Number.Text);

            v = double.Parse(TextBox_Number.Text);

            sqrt = Math.Sqrt(v);

            
            

            
            

            TextBox_Square.Text = square.ToString();

            TextBox_Cube.Text = cube.ToString();

            Textbox_SquareRoot.Text = sqrt.ToString();

            //SolutionWindow SolutionWindow = new SolutionWindow(v);

            //SolutionWindow.ShowDialog();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (this.IsLoaded)
            {
                UpdateUnits();
            }

            
        }
        private void UpdateUnits()
        {
            if ((bool)Radio_Parsecs.IsChecked)
            {
                _Units = "Parsecs";
            }

            else if ((bool)Radio_BeardS.IsChecked)
            {
                _Units = "Beard Seconds";
            }

            Label_Cube.Content = "(" + _Units +") " + "Cubed";

            Label_Square.Content = "(" + _Units +") " + "Squared";

            Label_Root.Content = "(" + _Units +") " + "SQ Root";

        }
                
    }
}
