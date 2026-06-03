using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolarGraphsLib
{
    public class SavingAndPullingUpSession
    {
        static string pathToSession_ = "Session\\Session.txt";
        /* public static List<PolarFunction> ReadPolarFunction()
         {
             List<PolarFunction> listFunctions = new List<PolarFunction>();
             string textFunctions = File.ReadAllText(pathToSession_);
             string[] arrayFunctions = textFunctions.Split('\n');

             for (int i = 0; i < arrayFunctions.Length; i++)
             {
                 string[] function = arrayFunctions[i].Split(';');
                 listFunctions.Add(new PolarFunction
                 {
                     Id = int.Parse(function[0]),
                     Name = function[1],
                     Function = function[2],
                     Step = Convert.ToDouble(function[3]),
                     StartCorner = Convert.ToDouble(function[4]),
                     EndCorner = Convert.ToDouble(function[5])
                 });
             }
             return listFunctions;
         }*/
        public static void SaveSession(PolarFunction polarFunction, bool boolListPoints)
        {
            string recordable = null;
            recordable = polarFunction.Name + ";" + polarFunction.Function + ";" + polarFunction.Step + ";" + 
                         polarFunction.StartCorner + ";" + polarFunction.EndCorner +'\n' + boolListPoints + '\n' + ThemeMode.IsDarkMode;

            File.WriteAllText(pathToSession_, recordable);
        }
    }
}
