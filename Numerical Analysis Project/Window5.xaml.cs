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

namespace Numerical_Analysis_Project
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        double eps = double.Parse(GlobalVaribles.Error);
        double xMins1 = double.Parse(GlobalVaribles.XMins1);
        double xNode = double.Parse(GlobalVaribles.X0);
        double f(double x)
        {
            CalculationEngine engine = new CalculationEngine();
            string fun = GlobalVaribles.Function;
            Dictionary<string, double> variables = new Dictionary<string, double>();
            variables.Add("x", x);
            double result = engine.Calculate(fun, variables);
            return result;
        }
        int iter = 0;
        double error = 0;
        double secant(double xiMins1 ,double xI)
        {
            double xiOld = xI;
            
            DataGridxaml.Items.Add(new Secant { iter = iter, xMins1 = Math.Round(xiMins1), fxMins1 = Math.Round(f(xiMins1), 3), xi = Math.Round(xI, 3), fxi = Math.Round(f(xI), 5), error = Math.Round(error, 3) });
            error = Math.Abs((xI - xiMins1) / xI) * 100;
            xI = xI - ((f(xI) * (xiMins1 - xI)) / (f(xiMins1) - f(xI)));
            xiMins1 = xiOld;
            iter++;
            if (error >= eps)
            {
                secant(xiMins1, xI);
            }
            return xI;
        }
        public Window5()
        {
            InitializeComponent();
            secant(xMins1, xNode);
        }
    }
}
