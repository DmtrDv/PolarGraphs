using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc.Domain;

namespace PolarGraphsLib
{
    public class ReadUserFunction
    {
        public (List<Points> listPolarPoints, List<Points> listCartesianPoints) ConvertUserFunction(double startConcer, double endConcer, double step, string userFunction)
        {
            List<Points> listPolarPoints = new List<Points>();
            List<Points> listCartesianPoints = new List<Points>();

            string expression = userFunction.ToLower().Replace(" ", "")
                                                          .Replace("abs", "AbsDouble")
                                                          .Replace("pi", "Pi");
            expression = Regex.Replace(expression, @"\basin\b", "Asin");
            expression = Regex.Replace(expression, @"\bacos\b", "Acos");
            expression = Regex.Replace(expression, @"\bsin\b", "Sin");
            expression = Regex.Replace(expression, @"\bcos\b", "Cos");
            expression = Regex.Replace(expression, @"\bsqrt\b", "Sqrt");
            expression = Regex.Replace(expression, @"\bpow\b", "Pow");

            NCalc.Expression expr = new NCalc.Expression(expression);
            expr.Parameters["Pi"] = Math.PI;
            expr.Parameters["e"] = Math.E;
            expr.EvaluateFunction += (name, args) =>
            {
                switch (name)
                {
                    case "AbsDouble":
                        object param = args.Parameters[0].Evaluate();
                        double value = Convert.ToDouble(param);
                        args.Result = Math.Abs(value);
                        break;
                }
            };
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] != '0')
                    continue;

                if (i > 0 && expression[i - 1] == '/')
                {
                    if (i + 1 < expression.Length)
                    {
                        if (expression[i + 1] == '.')
                            continue;
                    }
                    throw new InvalidOperationException("Деление на ноль в формуле");
                }
            }
            for (double concer = startConcer; concer <= endConcer; concer += step)
            {
                double concerRad = Math.Round(concer * Math.PI / 180, 10);
                expr.Parameters["fi"] = concerRad;

                double radius = (double)expr.Evaluate();

                listPolarPoints.Add(new Points(concerRad, radius));

                double x = radius * Math.Cos(concerRad);
                double y = radius * Math.Sin(concerRad);
                listCartesianPoints.Add(new Points(x, y));
            }
            return (listPolarPoints, listCartesianPoints);
        }
    }
}