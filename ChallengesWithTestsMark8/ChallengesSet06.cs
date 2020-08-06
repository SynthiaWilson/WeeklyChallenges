using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;
            foreach (string s in words)
            {
                if (s == null) return false;
                if (ignoreCase == true)
                { 
                    if (s.ToLower() == word.ToLower())
                        return true;
                }
                if (ignoreCase == false)
                {
                    if (s == word) return true;
                }

               
            
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 0) return false;

            if (num < 0) num = -num;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
