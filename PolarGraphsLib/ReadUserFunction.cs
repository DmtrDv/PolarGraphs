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
        public (List<Points> listPolarPoints, List<Points> listCartesianPoints) ConvertUserFunction(double startConcer, double endConcer, double step, string userFunction)
        {
            List<Points> listPolarPoints = new List<Points>();
            List<Points> listCartesianPoints = new List<Points>();
            for (double concer = startConcer; concer <= endConcer; concer += step)
            {
                double concerRad = Math.Round(concer * Math.PI / 180 , 10);

                string expression = userFunction.ToLower().Replace(" ", "")
                                                          .Replace("abs", "AbsDouble")
                                                          .Replace("pi", "Pi")
                                                          .Replace("e", "E");
                expression = Regex.Replace(expression, @"\basin\b", "Asin");
                expression = Regex.Replace(expression, @"\bacos\b", "Acos");
                expression = Regex.Replace(expression, @"\bsin\b", "Sin");
                expression = Regex.Replace(expression, @"\bcos\b", "Cos");
                expression = Regex.Replace(expression, @"\bsqrt\b", "Sqrt");
                expression = Regex.Replace(expression, @"\bpow\b", "Pow");
                //expression = Regex.Replace(expression, @"\batan\b", "Atan");
                //expression = Regex.Replace(expression, @"\btan\b", "Tan");
                //expression = Regex.Replace(expression, @"\blog\b", "Log");

                NCalc.Expression expr = new NCalc.Expression(expression);
                expr.Parameters["fi"] = concerRad;
                expr.Parameters["Pi"] = Math.PI;
                expr.Parameters["E"] = Math.E;
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

                double radius = (double)expr.Evaluate();
                /*try
                {
                    // Одна строка - конвертируем что угодно в double
                    radius = (double)Convert.ChangeType(result, typeof(double));
                    radius = Math.Round(radius, 10);
                }
                catch
                {
                    continue; // Любая ошибка - пропускаем точку
                }*/


                listPolarPoints.Add(new Points(concerRad, radius));

                double x = radius * Math.Cos(concerRad);
                double y = radius * Math.Sin(concerRad);

                listCartesianPoints.Add(new Points(x, y));
            }
            return (listPolarPoints, listCartesianPoints);
        }
    }
}
