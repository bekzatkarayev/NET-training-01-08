using System;

namespace Task01
{
    public class Program
    {
        public static double FindNthRoot(double number, int degree, double precision)
        {
            double guessResult = number / 2;
            double expectedResult = Math.Pow(number, 1.0 / degree);
            double result;

            while (Math.Abs(expectedResult - guessResult) > precision)
            {
                result = guessResult - Math.Pow(guessResult, degree) / (degree * Math.Pow(guessResult, degree));
                guessResult = result;
            }

            return 0;
        }

        static void Main()
        {
        }
    }
}
