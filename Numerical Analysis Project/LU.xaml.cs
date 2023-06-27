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
    /// Interaction logic for LU.xaml
    /// </summary>
    public partial class LU : Window
    {
        public LU()
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

            double[,] arr = { { X11, X12, X13,S1 },
                              { X21, X22, X23 ,S2},
                              { X31, X32, X33,S3 }};


            double m21 = arr[1, 0] / arr[0, 0];
            double m31 = arr[2, 0] / arr[0, 0];
            double[,] lower = new double[3, 3];
            double[,] upper = new double[3, 4];
            double[] b = new double[3];
            for (int i = 0; i < 3; i++)
            {
                b[i] = arr[i, 3];
            }


            for (int j = 0; j < 4; j++)
            {
                double e2 = arr[1, j];
                double e1 = ((m21 * arr[0, j]));
                arr[1, j] = e2 - e1;

            }
            for (int j = 0; j < 4; j++)
            {
                double e3 = arr[2, j];
                double e1 = ((m31 * arr[0, j]));
                arr[2, j] = e3 - e1;
            }

            double m32 = arr[2, 1] / arr[1, 1];
            for (int j = 0; j < 4; j++)
            {
                double e3 = arr[2, j];
                double e1 = ((m32 * arr[1, j]));
                arr[2, j] = e3 - e1;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    upper[i, j] = arr[i, j];
                }
            }
            lower[0, 1] = 0;
            lower[0, 2] = 0;
            lower[1, 2] = 0;

            lower[0, 0] = 1;
            lower[1, 1] = 1;
            lower[2, 2] = 1;

            lower[1, 0] = m21;
            lower[2, 0] = m31;
            lower[2, 1] = m32;

            double c1 = b[0] / lower[0, 0];
            double c2 = (b[1] - (lower[1, 0] * c1)) / lower[1, 1];
            double c3 = (b[2] - ((lower[2, 0] * c1) + (lower[2, 1] * c2))) / lower[2, 2];

            //textBoxC1.Text = c1.ToString();
            //textBoxC2.Text = c2.ToString();
            //textBoxC3.Text = c3.ToString();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = upper[i, j];
                }
            }
            arr[0, 3] = c1;
            arr[1, 3] = c2;
            arr[2, 3] = c3;

            double x3 = arr[2, 3] / arr[2, 2];
            double x2 = (arr[1, 3] - (arr[1, 2] * x3)) / arr[1, 1];
            double x1 = (arr[0, 3] - ((arr[0, 1] * x2) + arr[0, 2] * x3)) / arr[0, 0];

            sx1.Text = x1.ToString();
            sx2.Text = x2.ToString();
            sx3.Text = x3.ToString();

            SC1.Text = c1.ToString();
            SC2.Text = c2.ToString();
            SC3.Text = c3.ToString();


        }
    }
}
