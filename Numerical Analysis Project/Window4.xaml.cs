using System;
using System.Collections.Generic;
using System.Windows;

using Jace;
using org.mariuszgromada.math.mxparser;
using Expression = org.mariuszgromada.math.mxparser.Expression;

namespace Numerical_Analysis_Project
{

    public partial class Window4 : Window
    {
        double eps = double.Parse(GlobalVaribles.Error);
        double xNode = double.Parse(GlobalVaribles.X0);
        string fun = GlobalVaribles.Function;
        int iter = 0;
        double xi = 0;
        double xiplus1 = 0;
        double error = 0;
     

        public double fdash(double x)
        {

            Argument xI = new Argument($"x={x}");
            
           Expression e =new Expression($"der({fun},x)",xI);
            double efdash = e.calculate();
                return efdash;
        }

        double f(double x)
        {
            CalculationEngine engine = new CalculationEngine();
            string fun = GlobalVaribles.Function;
            Dictionary<string, double> variables = new Dictionary<string, double>();
            variables.Add("x", x);
            double result = engine.Calculate(fun, variables);
            return result;
        }
        double netwon(double x)
        {
            xi = x;
            
            DataGridxaml.Items.Add(new Netwon { iter=iter,XI=Math.Round(x,3),fXI=Math.Round(f(xi),3),fDashXI=Math.Round(fdash(xi), 3),error=Math.Round(error, 3) });
            xiplus1 = xi - (f(xi) / fdash(xi));
            error = Math.Abs((xiplus1 - xi) / xiplus1) * 100;
            iter++;
            if (error > eps )
            {
               
                netwon(xiplus1);
            }
            return xi;
        }
        public Window4()
        {
            InitializeComponent();
            netwon(xNode);
        }
    }
}
