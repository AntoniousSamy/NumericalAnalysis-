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
    /// Interaction logic for GoldenSectionData.xaml
    /// </summary>
    public partial class GoldenSectionData : Window
    {
        public GoldenSectionData()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Hide();
            Mw.Show();
        }

        private void Golden(object sender, RoutedEventArgs e)
        {

            string fun = GlobalVaribles.Function = Fun.Text;
            double xL = double.Parse(GlobalVaribles.XL = Xl.Text);
            double xU = double.Parse(GlobalVaribles.XU = Xu.Text);
            double Iter = double.Parse(GlobalVaribles.Iter = iter.Text);
            Window6 w6 = new Window6();
            this.Hide();
            w6.Show();
        }
    }
}
