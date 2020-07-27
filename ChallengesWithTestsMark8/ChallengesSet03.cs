using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i =0; i < vals.Length; i++)
            {
             if (vals[i] == false) return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //  Still missing the first test for some reason!!!!
            if (numbers == null) return false;
            if (numbers.Count() == 0) return false;
           
            int sum = 0;
            foreach (int i in numbers)
            {
                if ((i % 2 == 1) || (i % 2 == -1)) sum += i;
            }

            if ((sum % 2 == 1) || (sum % 2 == -1)) return true;
                return false;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(String password)
        {
            if (password.Any(char.IsUpper) &&
                password.Any(char.IsLower) &&
                password.Any(char.IsDigit)) return true;
            return false;
            
        }

        public char GetFirstLetterOfString(string val)
        {
            var c =  val.ToCharArray();
            return c[0];
        }

        public char GetLastLetterOfString(string val)
        {
            var c = val.ToCharArray();
            return c[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) return 0;
            return dividend/ divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            int last = nums.Length - 1;
            return nums[last] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            int cnt = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    odds[cnt] = i;
                    cnt++;
                }
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i=0; i< words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
