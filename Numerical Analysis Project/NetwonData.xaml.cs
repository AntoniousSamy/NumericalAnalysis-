using org.mariuszgromada.math.mxparser;
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
    /// Interaction logic for NetwonData.xaml
    /// </summary>
    public partial class NetwonData : Window
    {
        public NetwonData()
        {
            InitializeComponent();
        }

        private void Calc2(object sender, RoutedEventArgs e)
        {
            string fun = GlobalVaribles.Function = Fun.Text;
            double x0 = double.Parse(GlobalVaribles.X0 = xNode.Text);
            double err = double.Parse(GlobalVaribles.Error = ERR.Text);
            Window4 w4 = new Window4();
            this.Hide();
            w4.Show();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Hide();
            Mw.Show();
        }
    }
}
