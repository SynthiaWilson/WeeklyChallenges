using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int cnt = startNumber;
            cnt++;
            while (cnt % n != 0)
            {
                cnt++;
            }
            return cnt;

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business b in businesses)
            {
                if (b.TotalRevenue == 0d) b.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null) return false;
            if(( numbers.Length == 0) ||  (numbers == null)) return false;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] > numbers[i + 1]) return false;
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null) return 0;
            int sum  = 0;
            for (int i = 0; i < numbers.Length -1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
               
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null) return "";
            if (words.Length == 0) return "";
            string sentence = "";
            string s1 = "";

            int cnt = 0;
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] == " ") cnt++;
                
            }

            if (cnt == words.Length) return "";

            for (int i = 0; i < words.Length; i++)
            {
                s1 = string.Concat(words[i].Where(c => !Char.IsWhiteSpace(c)));

                if (s1.Length > 0) sentence += s1 + ' ';
                
            }
            return sentence.TrimEnd(' ') + ".";
        }
            
        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) 
                    {
                double[] nada = new double[0];
                return nada;
                    } 
            int cnt4 = 1;
            int i = 0;
            double[] fours = new double[elements.Count/4]; 
            foreach (double item in elements)
            {
                
                if (cnt4 % 4 == 0)
                {
                    fours[i] = item;
                    cnt4 = 0;
                    i++;
                }
                cnt4++;
            }
            return fours; 
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == targetNumber) return true;        
                    }
                   
                }
            
            }
            return false;
        }
    }
}
