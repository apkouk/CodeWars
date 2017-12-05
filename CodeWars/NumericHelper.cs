using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class NumericHelper
    {
        //KATA Remove the minimum
        public static List<int> RemoveSmallestIntegerFromCollection(List<int> numbers)
        {
            numbers.Remove(numbers.DefaultIfEmpty().Min());
            return numbers;
        }

        //KATA Triple trouble
        public static int FindTripleAndDouble(long number1, long number2)
        {
            

            ArrayList numberFromNumber1 = FindStraightNumbers(number1, 3);
            ArrayList numberFromNumber2 = FindStraightNumbers(number2, 2);

            foreach (char c in numberFromNumber1)
            {
                if (numberFromNumber2.Contains(c))
                {
                    return 1;
                }
            }
            return 0;

            //BEST FROM CODEWARS
            //return "0123456789".Count(number => number1.ToString().Contains(new string(number, 3)) && number2.ToString().Contains(new string(number, 2)));
        }
        private static ArrayList FindStraightNumbers(long number, int timesRepeated)
        {
            char[] numbers = number.ToString().ToArray();
            ArrayList result = new ArrayList();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i + (timesRepeated - 1) < numbers.Length)
                {
                    if (numbers[i].Equals(numbers[i + (timesRepeated - 2)]) && numbers[i + (timesRepeated - 2)].Equals(numbers[i + (timesRepeated - 1)]))
                    {
                        result.Add(numbers[i]);
                    }
                }
            }
            return result;
        }

        //KATA Playing with digits
        public static int PlayingWithDigits(int digitToPlayWith, int factor)
        {
            double totalSumAndPow = 0;
            foreach (char number in digitToPlayWith.ToString())
            {
                totalSumAndPow += Math.Pow(Convert.ToDouble(number.ToString()), factor++);
            }
            return Convert.ToInt32(totalSumAndPow % digitToPlayWith == 0 ? totalSumAndPow / digitToPlayWith : -1);
            //ORIGINAL
            //if ((totalSumAndPow % digitToPlayWith) == 0)
            //    return Convert.ToInt32(totalSumAndPow / digitToPlayWith);
            //return -1;    

            //IMPROVEMENT
            //return Convert.ToInt32(totalSumAndPow % digitToPlayWith == 0 ? totalSumAndPow / digitToPlayWith : -1);

            //BEST FROM CODEWARS
            //var sum = Convert.ToInt64(n.ToString().Select(s => Math.Pow(int.Parse(s.ToString()), p++)).Sum());
            //return sum % n == 0 ? sum / n : -1;
        }

    }
}
