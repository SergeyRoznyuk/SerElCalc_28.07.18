using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerElCalc;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        public static float cutString(string str)
        {
            int searchLength = str.IndexOf("E+") == -1 ? str.Length : str.IndexOf("E+");
            str = str.Substring(0, searchLength);

            return float.Parse(str);
        }


        [TestMethod]
        public void TestSum()
        {
            Calculator calc = Calculator.getCalculator();

            Random r = new Random();
            int size = 10;
            float[] x = new float[size];
            float[] y = new float[size];

            float tmp;

            for (int i = 0; i < size; i++)
            {
                tmp = r.Next();
                x[i] = cutString(tmp.ToString());

                tmp = r.Next();
                y[i] = cutString(tmp.ToString());
            }

            float expected;
            float actual;

            for (int i = 0; i < size; i++)
            {
                expected = x[i] + y[i];
                calc.A = x[i];
                calc.B = y[i];

                actual = calc.sum();
                Assert.AreEqual(expected, actual);
            }

        }

        [TestMethod]
        public void TestSub()
        {
            Calculator calc = Calculator.getCalculator();

            Random r = new Random();
            int size = 10;
            float[] x = new float[size];
            float[] y = new float[size];

            for (int i = 0; i < size; i++)
            {
                x[i] = r.Next() % 1000;
                y[i] = r.Next() % 1000;
            }

            float expected;
            float actual;

            for (int i = 0; i < size; i++)
            {
                expected = x[i] - y[i];
                calc.A = x[i];
                calc.B = y[i];

                actual = calc.sub();
                Assert.AreEqual(expected, actual);
            }

        }

        [TestMethod]
        public void TestMult()
        {
            Calculator calc = Calculator.getCalculator();

            Random r = new Random();
            int size = 10;
            float[] x = new float[size];
            float[] y = new float[size];

            for (int i = 0; i < size; i++)
            {
                x[i] = r.Next() % 1000;
                y[i] = r.Next() % 1000;
            }

            float expected;
            float actual;

            for (int i = 0; i < size; i++)
            {
                expected = x[i] * y[i];
                calc.A = x[i];
                calc.B = y[i];

                actual = calc.mult();
                Assert.AreEqual(expected, actual);
            }

        }

        [TestMethod]
        public void TestDiv()
        {
            Calculator calc = Calculator.getCalculator();

            Random r = new Random();
            int size = 10;
            float[] x = new float[size];
            float[] y = new float[size];

            for (int i = 0; i < size; i++)
            {
                x[i] = r.Next() % 1000;
                y[i] = r.Next() % 1000;
            }

            float expected;
            float actual;

            for (int i = 0; i < size; i++)
            {
                expected = x[i] / y[i];
                calc.A = x[i];
                calc.B = y[i];

                actual = calc.div();
                Assert.AreEqual(expected, actual);
            }

        }
    }
}
