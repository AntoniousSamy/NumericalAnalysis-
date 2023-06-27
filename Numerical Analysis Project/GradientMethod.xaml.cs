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
using org.mariuszgromada.math.mxparser;
using Expression = org.mariuszgromada.math.mxparser.Expression;

namespace Numerical_Analysis_Project
{
    /// <summary>
    /// Interaction logic for GradientMethod.xaml
    /// </summary>
    public partial class GradientMethod : Window
    {
        
        public string Xdash(string x)
        {
            //Argument xI = new Argument($"x={x}");
            Expression e = new Expression($"der({x},x)");
            return e.getExpressionString();
        }
        public string Ydash(string y)
        {
            //Argument yI = new Argument($"y={y}");
            Expression c = new Expression($"der({y},y)");
            return c.getExpressionString();
        }
        double fx(double x,string FunX)
        {
            CalculationEngine engine = new CalculationEngine();
            Dictionary<string, double> variables = new Dictionary<string, double>();
            variables.Add("x", x);
            double result = engine.Calculate(FunX, variables);
            return result;
        }
        double fy(double Y, string FunY)
        {
            CalculationEngine engine = new CalculationEngine();
            Dictionary<string, double> variables = new Dictionary<string, double>();
            variables.Add("y", Y);
            double result = engine.Calculate(FunY, variables);
            return result;
        }

        public GradientMethod()
        {
            InitializeComponent();
        }

        private void Calc2(object sender, RoutedEventArgs e)
        {
            string fun = Fun.Text;
            double x = double.Parse(XX.Text);
            double y = double.Parse(YY.Text);
           string X1 = Xdash(fun);
           string Y1 = Ydash(fun);
           string X2 = Xdash(X1);
           string Y2 = Ydash(Y1);
           string X3 = Ydash(X1);
           string Y3 = Xdash(Y1);
            double XS1 = fx(x, X2);
            double YS1 = fx(y, Y2);
            double XS2 = fx(x, X3);
            double YS2 = fx(y, Y3);
            double H = (XS1 * YS1) + (XS2 * YS2);
            if (H > 0 && XS1 > 0)
            {
                Ans.Text = "Local Min";
            }
            else if (H > 0 && XS1 < 0)
            {
                Ans.Text = "Local Max";
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            this.Hide();
            MW.Show();
        }
    }
}
