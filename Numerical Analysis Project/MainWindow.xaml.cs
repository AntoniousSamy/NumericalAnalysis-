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
namespace Numerical_Analysis_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   public  partial class MainWindow : Window
    {
   
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void FalsePostion(object sender, RoutedEventArgs e)
        {

            FalData FD = new FalData();
            this.Hide();
            FD.Show();
        }

        private void SimpleFixed(object sender, RoutedEventArgs e)
        {
            SimpileFixedData SFD = new SimpileFixedData();
            this.Hide();
            SFD.Show();
        }

        private void Netwon(object sender, RoutedEventArgs e)
        {
            NetwonData ND = new NetwonData();
            this.Hide();
            ND.Show();
        }

        private void Secant(object sender, RoutedEventArgs e)
        {
            SecantData SD =new SecantData();
            this.Hide();
            SD.Show();
        }

        private void GaussElimunation(object sender, RoutedEventArgs e)
        {
            GuessElimination GU = new GuessElimination();
            this.Hide();
            GU.Show();
        }

        private void Cramer(object sender, RoutedEventArgs e)
        {
            Cramer Cr = new Cramer();
            this.Hide();
            Cr.Show();
        }

        private void Bisection(object sender, RoutedEventArgs e)
        {
            BisFalData BF = new BisFalData();
            this.Hide();
            BF.Show();

        }

        private void LU(object sender, RoutedEventArgs e)
        {
            LU L = new LU();
            this.Hide();
            L.Show();
        }

        private void Golden_Section(object sender, RoutedEventArgs e)
        {
            GoldenSectionData GS = new GoldenSectionData();
            this.Hide();
            GS.Show();
        }

        private void Gradient_Method(object sender, RoutedEventArgs e)
        {
            GradientMethod GM = new GradientMethod();
            this.Hide();
            GM.Show();
        }
    }
}
