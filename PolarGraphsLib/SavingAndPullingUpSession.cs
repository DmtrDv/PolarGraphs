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
         public static (PolarFunction, bool, bool) PullingUpSession()
         {
             string textSession = File.ReadAllText(pathToSession_);
             string[] arraySession = textSession.Split('\n');

             string[] function = arraySession[0].Split(';');
             PolarFunction polarFunctionFromLastSession = new PolarFunction()
             {
                 Id = -1,
                 Name = function[1],
                 Function = function[2],
                 Step = Convert.ToDouble(function[3]),
                 StartCorner = Convert.ToDouble(function[4]),
                 EndCorner = Convert.ToDouble(function[5])
             };
             bool boolListPoints = Convert.ToBoolean(arraySession[1]);
             bool darkMode = Convert.ToBoolean(arraySession[2]);
             return (polarFunctionFromLastSession, boolListPoints, darkMode);
         }
        public static void SaveSession(PolarFunction polarFunction, bool boolListPoints)
        {
            string recordable = null;
            recordable = polarFunction.Name + ";" + polarFunction.Function + ";" + polarFunction.Step + ";" + 
                         polarFunction.StartCorner + ";" + polarFunction.EndCorner +'\n' + boolListPoints + '\n' + ThemeMode.IsDarkMode;

            File.WriteAllText(pathToSession_, recordable);
        }
    }
}
