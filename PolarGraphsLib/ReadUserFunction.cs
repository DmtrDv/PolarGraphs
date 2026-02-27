using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using NCalc.Domain;

namespace PolarGraphsLib
{
    public class ReadUserFunction
    {
            public (List<Points> listPolarPoints, List<Points> listCartesianPoints) ConvertUserFunction(float startConcer, float endConcer, float step, string userFunction)
            {
            List<Points> listPolarPoints = new List<Points>();
            List< Points > listCartesianPoints = new List<Points>();
            for (double concer = startConcer; concer <= endConcer; concer += step)
            {
                double concerRad = concer * Math.PI / 180;

                string expression = userFunction.ToLower()
                     .Replace(" ", "")
                     .Replace("sin", "Sin")
                     .Replace("cos", "Cos")
                     .Replace("tan", "Tan")
                     .Replace("sqrt", "Sqrt")
                     .Replace("log", "Log")
                     .Replace("asin", "Asin")
                     .Replace("acos", "Acos")
                     .Replace("atan", "Atan")
                     ;

                // .Replace("fi", concerRad.ToString(System.Globalization.CultureInfo.InvariantCulture));
                NCalc.Expression expr = new NCalc.Expression(expression);
                expr.Parameters["fi"] = concerRad;

                double r = Convert.ToDouble(expr.Evaluate());

                listPolarPoints.Add(new Points(concerRad, r));

                double x = r * Math.Cos(concerRad);
                double y = r * Math.Sin(concerRad);

                listCartesianPoints.Add(new Points(x, y));
            }
            return (listPolarPoints, listCartesianPoints);
        }
    }
}
