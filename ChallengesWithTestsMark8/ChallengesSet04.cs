using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sumE = 0;
            int sumO = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0) sumE += i;
                else
                    sumO += i;
            }

            return sumE - sumO;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int cnt = str1.Length;
            if (str2.Length < cnt)
            { cnt = str2.Length; }

            else if (str3.Length < cnt)
            { cnt = str3.Length; }
            else if (str4.Length < cnt)
            { cnt = str4.Length; }
            return cnt;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int cnt = number1;
            if (number2 < cnt) { cnt = number2; }
            if (number3 < cnt) { cnt = number3; }
            if (number4 < cnt) { cnt = number4; }
            return cnt;

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz) => biz.Name = "TrueCoders";



        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength3 <= 0) || (sideLength2 <= 0) || (sideLength3 <= 0)) return false;
            if (sideLength1 + sideLength2 > sideLength3) {
                if (sideLength3 + sideLength1 > sideLength2)
                {
                    if (sideLength3 + sideLength2 > sideLength1) return true;
                }
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if ((input == "") || (input == null)) return false;
            if (input.Substring(0, 1) == "-") return true;
            if (Regex.IsMatch(input, @"^\d+$") || input.Contains(".")) return true;
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int majority = (objs.Length / 2) + 1;
            int cnt = 0;
            foreach (var i in objs)
            {
                if (i == null) cnt++;
            }
            if (cnt >= majority) return true;
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if ((numbers.Length == 0) || (numbers == null)) return 0;
            double CntE = 0.0;
            double SumE = 0.0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    CntE++;
                    SumE += numbers[i];

                }
            }
            if (SumE == 0.0) return 0;
            return SumE / CntE;




        }

        public int Factorial(int number)
        {
            if (number == 0) return 1;
            if (number < 0) throw new ArgumentOutOfRangeException("number");

            int fact = number;
            for (int i = number - 1; i >= 1; i--)
            {
                fact *= i;
            }
            return fact;

        }

        
    }
}
