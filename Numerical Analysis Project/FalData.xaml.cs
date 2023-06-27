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
    /// Interaction logic for FalData.xaml
    /// </summary>
    public partial class FalData : Window
    {
        public FalData()
        {
            InitializeComponent();
        }

        private void Fal(object sender, RoutedEventArgs e)
        {
            string fun = GlobalVaribles.Function = Fun.Text;
            double xL = double.Parse(GlobalVaribles.XL = Xl.Text);
            double xU = double.Parse(GlobalVaribles.XU = Xu.Text);
            double err = double.Parse(GlobalVaribles.Error = ERR.Text);
            Window2 w2 = new Window2();
            this.Hide();
            w2.Show();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Hide();
            Mw.Show();
        }
    }
}
