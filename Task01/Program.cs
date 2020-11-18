using System;

namespace Task01
{
    public class Program
    {
        /// <summary>
        /// Calculates nth root of the real number with a given accuracy by using Newton's method.
        /// </summary>
        /// <param name="number">Input real number.</param>
        /// <param name="degree">Degree of the root.</param>
        /// <param name="precision">Required accuracy of the calculation.</param>
        /// <returns>A double-precision floating-point number.</returns>
        public static double FindNthRoot(double number, int degree, double precision)
        {
            if (degree < 0 || (precision < 0 || precision > 1) || (number < 0 && degree % 2 == 0))
            {
                throw new ArgumentOutOfRangeException();
            }

            double tempResult = number / 2.0;
            double result = 0.0;
            double difference = int.MaxValue;
            int digits = 0;

            while (difference > precision)
            {
                result = ApplyNewtonsFormula(number, tempResult, degree - 1.0);
                difference = Math.Abs(result - tempResult);
                tempResult = result;
            }

            while (precision < 1)
            {
                precision *= 10;
                digits++;
            }

            return Math.Round(result, digits);
        }

        /// <summary>
        /// Applies Newton's formula to calculate approximate nth root of a given real number.
        /// </summary>
        /// <param name="number">Input real number.</param>
        /// <param name="tempResult">Guessed value of the root.</param>
        /// <param name="degree">Degree of the root.</param>
        /// <returns>A double-precision floating-point number.</returns>
        public static double ApplyNewtonsFormula(double number, double tempResult, double degree)
        {
            return ((degree * tempResult) + (number / Math.Pow(tempResult, degree))) / (degree + 1);
        }

        public static void Main()
        {
        }
    }
}
