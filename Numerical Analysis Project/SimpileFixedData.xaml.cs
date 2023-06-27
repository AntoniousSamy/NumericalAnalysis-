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
using System.Windows.Shapes;


namespace Numerical_Analysis_Project
{
    /// <summary>
    /// Interaction logic for SimpileFixedData.xaml
    /// </summary>
    public partial class SimpileFixedData : Window
    {
        public SimpileFixedData()
        {
            InitializeComponent();
        }

        private void Calc(object sender, RoutedEventArgs e)
        {
            string fun = GlobalVaribles.Function = Fun.Text;
            double x0 = double.Parse(GlobalVaribles.X0 = xNode.Text);
            double err = double.Parse(GlobalVaribles.Error = ERR.Text);
            Window3 w3 = new Window3();
            this.Hide();
            w3.Show();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Hide();
            Mw.Show();
        }
    }
}
