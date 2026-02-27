using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NCalc.Domain;

namespace PolarGraphsLib
{
    public class ReadUserFunction
    {
        public (List<Points> listPolarPoints, List<Points> listCartesianPoints) ConvertUserFunction(float startConcer, float endConcer, float step, string userFunction)
        {
            List<Points> listPolarPoints = new List<Points>();
            List<Points> listCartesianPoints = new List<Points>();
            for (double concer = startConcer; concer <= endConcer; concer += step)
            {
                double concerRad = Math.Round(concer * Math.PI / 180 , 10);

                string expression = userFunction.ToLower().Replace(" ", "");
                expression = Regex.Replace(expression, @"\basin\b", "Asin");
                expression = Regex.Replace(expression, @"\bacos\b", "Acos");
                expression = Regex.Replace(expression, @"\batan\b", "Atan");
                expression = Regex.Replace(expression, @"\bsin\b", "Sin");
                expression = Regex.Replace(expression, @"\bcos\b", "Cos");
                expression = Regex.Replace(expression, @"\btan\b", "Tan");
                expression = Regex.Replace(expression, @"\bsqrt\b", "Sqrt");
                expression = Regex.Replace(expression, @"\blog\b", "Log");
                expression = Regex.Replace(expression, @"\bpow\b", "Pow");
                expression = Regex.Replace(expression, @"\babs\b", "Abs");

                    /*.Replace("sin", "Sin")
                     .Replace("cos", "Cos")
                     .Replace("tan", "Tan")
                     .Replace("sqrt", "Sqrt")
                     .Replace("log", "Log")
                     .Replace("asin", "Asin")
                     .Replace("acos", "Acos")
                     .Replace("atan", "Atan")
                     .Replace("pow", "Pow")
                     .Replace("abs", "Abs")
                     ;*/

                // .Replace("fi", concerRad.ToString(System.Globalization.CultureInfo.InvariantCulture));
                NCalc.Expression expr = new NCalc.Expression(expression);
                expr.Parameters["fi"] = concerRad;

                double r = Convert.ToDouble(expr.Evaluate());
                if (double.IsNaN(r) || double.IsInfinity(r))
                    continue;
                listPolarPoints.Add(new Points(concerRad, r));

                double x = r * Math.Cos(concerRad);
                double y = r * Math.Sin(concerRad);

                listCartesianPoints.Add(new Points(x, y));
            }
            return (listPolarPoints, listCartesianPoints);
        }
    }
}
