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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        double iter = double.Parse(GlobalVaribles.Iter);
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
        public void Golden()
        {
            double x1=0;
            double x2=0;
            double r = 0.618;
            double d = 0;
            int i = 0;
            do
            {
                d = r*(xU - xL);
                x1 = xL + d;
                x2 = xU - d;
                DataGridxaml.Items.Add(new Golden { iter = i, XL = xL, fXL = f(xL), X2 = x2, fX2 = f(x2), X1 = x1, fX1 = f(x1), XU = xU, fXU = f(xU), D = d });
                if (f(x2) > f(x1))
                    xU = xL+d;
                else
                    xL = xU-d;
                i++;
            } while (iter>=i);
            
        }
            public Window6()
        {
            InitializeComponent();
            Golden();
        }
    }
}
