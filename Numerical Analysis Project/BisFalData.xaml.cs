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
    /// Interaction logic for BisFalData.xaml
    /// </summary>
    public partial class BisFalData : Window
    {
        public BisFalData()
        {
            InitializeComponent();
        }

        private void Bis(object sender, RoutedEventArgs e)
        {
            
            string fun = GlobalVaribles.Function = Fun.Text;
            double xL = double.Parse(GlobalVaribles.XL =Xl.Text); 
            double xU = double.Parse(GlobalVaribles.XU = Xu.Text);
            double err = double.Parse(GlobalVaribles.Error = ERR.Text);

            Window1 w1 = new Window1();
            this.Hide();
            w1.Show();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Hide();
            Mw.Show();
        }

        private void Fun_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
