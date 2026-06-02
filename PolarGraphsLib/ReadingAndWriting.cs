using NCalc.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolarGraphsLib
{
    public class ReadingAndWriting
    {
        static string pathToListFunction_ = "Functions\\Functions.txt";
        public static List<PolarFunction> ReadPolarFunction()
        {
            List<PolarFunction> listFunctions = new List<PolarFunction>();
            string textFunctions = File.ReadAllText(pathToListFunction_);
            string[] arrayFunctions = textFunctions.Split('\n');

            for (int i = 0; i < arrayFunctions.Length; i++)
            {
                string[] function = arrayFunctions[i].Split(';');
                listFunctions.Add(new PolarFunction { Id = int.Parse(function[0]), Name = function[1], 
                                                      Function = function[2], Step = Convert.ToDouble(function[3]),
                                                      StartCorner = Convert.ToDouble(function[4]),
                                                      EndCorner = Convert.ToDouble(function[5])
                });
            }
            return listFunctions;
        }

        public static void WritePolarFunction(List<PolarFunction> listPolarFunctions)
        {
            string recordable = null;

            for (int i = 0; i < listPolarFunctions.Count; i++)
            {
                PolarFunction polarFunction = listPolarFunctions[i];
                
                if (i == listPolarFunctions.Count - 1)
                {
                    recordable += polarFunction.Id + ";" + polarFunction.Name + ";" + polarFunction.Function + ";" +
                                  polarFunction.Step + ";" + polarFunction.StartCorner + ";" + polarFunction.EndCorner;
                }
                else
                {
                    recordable += polarFunction.Id + ";" + polarFunction.Name + ";" + polarFunction.Function + ";" + 
                                  polarFunction.Step + ";" + polarFunction.StartCorner + ";" + polarFunction.EndCorner + "\n";
                }
            }
            File.WriteAllText(pathToListFunction_, recordable);
        }
    }
}
