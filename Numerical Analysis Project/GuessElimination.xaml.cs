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
    /// Interaction logic for GuessElimination.xaml
    /// </summary>
    public partial class GuessElimination : Window
    {

        public GuessElimination()
        {
            InitializeComponent();
        }

        private void Gu(object sender, RoutedEventArgs e)
        {
            double X11 = double.Parse(x11.Text);
            double X12 = double.Parse(x12.Text);
            double X13 = double.Parse(x13.Text);
            double S1 = double.Parse(s1.Text);

            double X21 = double.Parse(x21.Text);
            double X22 = double.Parse(x22.Text);
            double X23 = double.Parse(x23.Text);
            double S2 = double.Parse(s2.Text);

            double X31 = double.Parse(x31.Text);
            double X32 = double.Parse(x32.Text);
            double X33 = double.Parse(x33.Text);
            double S3 = double.Parse(s3.Text);

            double m21, m31, m32;
            double[,] a = new double[3, 4]{
                {X11 , X12 , X13 , S1 },
                {X21 , X22 , X23 , S2 },
                {X31 , X32 , X33 , S3 },
            };
            m21 = a[1, 0] / a[0, 0];
            m31 = a[2, 0] / a[0, 0];
            //rule E2-(m21)E1=E2
            for (int j = 0; j <4; j++)
            {
                double e2 = a[1, j];
                double e1 = ((m21) * a[0, j]);
                a[1, j] = e2 - e1;
            }
            //rule E3-(m31)E1=E3
            for (int j = 0; j < 4; j++)
            {
                double e3 = a[2, j];
                double e1 = ((m31) * a[0, j]);
                a[2, j] = e3 - e1;
            }
            m32 = a[2, 1] / a[1, 1];
            //rule E3-(m32)E2=E3
            for (int j = 0; j < 4; j++)
            {
                double e3 = a[2, j];
                double e1 = ((m32) * a[1, j]);
                a[2, j] = e3 - e1;
            }

            double x3 = a[2, 3] / a[2, 2];
            double x2 = (a[1, 3] - (a[1, 2] * x3)) / a[1, 1];
            double x1 = (a[0, 3] - ((a[0, 1] * x2) + (a[0, 2] * x3))) / a[0, 0];
            Math.Round(x1, 2);
            Math.Round(x2, 2);
            Math.Round(x3, 2);
         
            sx1.Text = x1.ToString();
            sx2.Text = x2.ToString();
            sx3.Text = x3.ToString();
        }
    }
}
