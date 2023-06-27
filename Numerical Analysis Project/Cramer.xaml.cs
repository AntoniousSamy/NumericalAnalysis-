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
    /// Interaction logic for Cramer.xaml
    /// </summary>
    public partial class Cramer : Window
    {
        public double determinantOfMatrix(double[,] cr)
        {
            double ans;
            ans = cr[0, 0] * ((cr[1, 1] * cr[2, 2])-(cr[1, 2] * cr[2, 1]))
                - cr[0, 1] * ((cr[1, 0] * cr[2, 2])- (cr[1, 2] * cr[2, 0]))
                + cr[0, 2] * ((cr[1, 0] * cr[2, 1]) -( cr[1, 1] * cr[2, 0]));
            return ans;
        }
        public Cramer()
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

            double[,] d = { { X11, X12, X13 },
                           { X21, X22, X23 },
                           { X31, X32, X33 } };

            double[,] d1 = { {S1, X12, X13 },
                             {S2, X22, X23 },
                             {S3, X32, X33 } };

            double[,] d2 = { {X11, S1, X13 },
                           { X21, S2, X23 },
                           { X31, S3, X33 } };

            double[,] d3 = { {X11, X12, S1},
                           { X21, X22, S2 },
                           { X31, X32, S3 } };
            double D = determinantOfMatrix(d);
            double D1 = determinantOfMatrix(d1);
            double D2 = determinantOfMatrix(d2);
            double D3 = determinantOfMatrix(d3);
            if (D != 0)
            {
                
                double x1 = D1 / D;
                double x2 = D2 / D;
                double x3 = D3 / D; 

                sx1.Text = Math.Round(x1,3).ToString();
                sx2.Text = Math.Round(x2, 3).ToString();
                sx3.Text = Math.Round(x3, 3).ToString();
            }
        }
    }
}
