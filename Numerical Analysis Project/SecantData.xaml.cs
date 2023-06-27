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
    /// Interaction logic for SecantData.xaml
    /// </summary>
    public partial class SecantData : Window
    {
        public SecantData()
        {
            InitializeComponent();
        }

        private void Secant(object sender, RoutedEventArgs e)
        {
            string fun = GlobalVaribles.Function = Fun.Text;
            double xMins1 = double.Parse(GlobalVaribles.XMins1 = XMins1.Text);
            double xU = double.Parse(GlobalVaribles.X0 = xNode.Text);
            double err = double.Parse(GlobalVaribles.Error = ERR.Text);
            Window5 w5 = new Window5();
            this.Hide();
            w5.Show();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Hide();
            Mw.Show();
        }
    }
}
