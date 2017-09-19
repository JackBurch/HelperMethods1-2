using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods1
{
    class Program
    {
        static void Main(string[] args)
        {
            // this declares a varable called myValue, and sets it equal to superSecretFomula
            string myValue = superSecretFormula("sunshine");
            Console.WriteLine(myValue);
            Console.ReadLine();
        }
        // this is a private static string equal to superSecret Formula
        private static string superSecretFomula()
        {
            //some cool stuff here
            return "Hello World";
        }
        private static string superSecretFormula(string name)
        {
            return String.Format("Hello, {0}!", name);
        }
    }
}
