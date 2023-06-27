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
using Jace;
using static System.Math;


namespace Numerical_Analysis_Project
{
   
    public partial class Window2 : Window
    {
        double eps = double.Parse(GlobalVaribles.Error);
        double xL = double.Parse(GlobalVaribles.XL);
        double xU = double.Parse(GlobalVaribles.XU);

        double f(double x)
        {
            CalculationEngine engine = new CalculationEngine();
            string fun = GlobalVaribles.Function;
            Dictionary<string, double> variables = new Dictionary<string, double>();
            variables.Add("x", x);
            double result = engine.Calculate(fun, variables);
            return result;
        }
        public double falsePosition()
        {

            int iter = 0;
            double XR = 0;
            double error = 0;
            double xrOld = 0;
            do
            {
                xrOld = XR;
                XR = xU - (f(xU) * (xL - xU)) / (f(xL) - f(xU));
                error = Math.Abs((XR - xrOld) / XR) * 100;
                DataGridxaml.Items.Add(new Bis_Fal { iter = iter, XL = Math.Round(xL,3), fXL =Math.Round(f(xL),3), XU =Math.Round(xU,3), fXU =Math.Round(f(xU),3), XR =Math.Round(XR,3), fXR = Math.Round(f(XR),3), error = Math.Round(error,3)});
                if (f(xL) * f(XR) > 0)
                    xL = XR;
                else
                    xU = XR;
                iter++;
            } while (error > eps);
            return XR;

        }
        public Window2()
        {
            double root;
            InitializeComponent();
            if (f(xL) * f(xU) < 0)
                root = falsePosition();
            else
                MessageBox.Show("Not Correct XU or XL");
        }
    }
}
