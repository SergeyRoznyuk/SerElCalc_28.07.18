using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerElCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calc = Calculator.getCalculator();
            //var a = Console.ReadLine();
            //calc.A = a;

            //calc.B = Console.ReadLine();

            //Console.WriteLine(calc.div());

            int size = 10;
            Random r = new Random();

            float[] y = new float[size];

            for (int i = 0; i < size; i++)
            {
                y[i] = r.Next();
            }

            string tmpString = "";

            foreach (var value in y)
            {
                Console.WriteLine(value.ToString());
            }


            Console.WriteLine("\n_____________________\n");

            for (int i = 0; i < y.Length; i++)
            {
                y[i] = cutString((y[i].ToString()));
            }

            foreach (var value in y)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Finished!");

            Console.Read();
        }

        public static float cutString(string str)
        {
            int searchLength = str.IndexOf("E+") == -1 ? str.Length : str.IndexOf("E+");
            str = str.Substring(0, searchLength);

            return float.Parse(str);
        }
    }
}
