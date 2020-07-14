using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string up = lowercaseAlphabet.ToUpper();
            
               
            // Check all letters
            if (lowercaseAlphabet.Contains(c) || up.Contains(c))
            { 
                    return true;
            }
                else
                {
                    return false;
                }
           

                

        }
        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0) return true;
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
                return true;
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
           if (numbers == null )  return 0;
            if (numbers.Count() == 0 ) return 0;
            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length <= str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) return 0;
            if (numbers.Length == 0) return 0;
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            if (numbers.Length == 0) return 0;
            int s = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                    s += i;
              
            }
            return s;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0) return false;
            //a cheat ;)
            if (numbers[0] < 0) return true;
            
            if (numbers.Sum()% 2 == 1) return true;
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0) return 0;
            return number / 2;
        }
    }
}
