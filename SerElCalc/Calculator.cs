using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerElCalc
{
    public class Calculator
    {
        private static Calculator calc;
        private float a = 0;
        private float b = 0;

        Calculator() { }

        public static Calculator getCalculator ()
        {
            if (calc == null)
                calc = new Calculator();
            return calc;
        }

        private static bool isPrimitive (object obj)
        {
            return obj.GetType() == typeof(double) || obj.GetType() == typeof(float) || obj.GetType() == typeof(int) || obj.GetType() == typeof(string) || obj.GetType() == typeof(char) ? true : false;
        }

        private static bool IsEmpty(object obj)
        {
            return obj == null || obj.ToString() == "" ? true: false;
        }
        
        private static bool isNumeric(object obj)
        {
            bool control = true;
            int countComma = 0;

            foreach (var symbol in obj.ToString())
            {
                if (!Char.IsNumber(symbol))
                {
                    if (symbol == ',' && countComma < 1)
                    {
                        countComma++;
                        continue;
                    }
                    else
                    {
                        control = false;
                        break;
                    }
                }

            }

            return control;
        }

        private float setNumber (object obj)
        {
            if (isPrimitive(obj) == true && IsEmpty(obj) == false && isNumeric(obj) == true)
                return float.Parse(obj.ToString());
            else
                throw new Exception("Incorrect value");
        }

        public object A
        {
            get { return (float) a; }
            set { a = setNumber(value);}
        }

        public object B
        {
            get { return (float) b; }
            set { b = setNumber(value); }
        }

        public float sum ()
        {
            return a + b;
        }

        public float sub ()
        {
            return a - b;
        }

        public float mult ()
        {
            return a * b;
        }

        public float div ()
        {
            if (b != 0)
                return a / b;
            throw new Exception("Prohibited operation! You can not divide by zero!");
        }
    }
}
