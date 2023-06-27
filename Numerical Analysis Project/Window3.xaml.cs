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
   
    public partial class Window3 : Window
    {
        
        double eps = double.Parse(GlobalVaribles.Error);
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
        double xi = 0;
        double xiplus1 = 0;
        double error = 0;
        public double SimpleFixedPoint(double x)
        {
            xi = x;
            xiplus1 = f(xi);
            error = Math.Abs((xiplus1 - xi) / xiplus1) * 100;
            DataGridxaml.Items.Add(new SimpleFixed {iter=iter,XI= Math.Round(x, 3),fXI = Math.Round(xiplus1, 3),Error = Math.Round(error, 3) });
            iter++;
            if (error >= eps)
            {
                SimpleFixedPoint(xiplus1);
            }
            return xi;
        }
        public Window3()
        {
            InitializeComponent();
            SimpleFixedPoint(xNode);
           
        }

       
    }
}
