using System;
using System.Collections.Generic;
using Xunit;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet03Tests
    {

        public bool ArrayContainsAFalse(bool[] values, bool expected)
        { for (int i = 0; i < values.Length; i++)
            {
                if (values[1] == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                public int IsSumOfOddsOdd(IEnumerable<int> numbers, bool expected)
                {
                    if (numbers == null || numbers.Count() == 0)
                    {
                        return false;
                    }
                    var sum = numbers.Sum();
                    return (sum % 2 != 0);
                }

                public bool PasswordContainsUpperLowerAndNumber(string password, bool expected)
                {
                    var isLower = false;
                    var isUpper = false;
                    var isNumber = false;
                    for (int i = 0; i < password.Length; i++)

                        if (char.IsLower(password[i]))
                        {
                            isLower = true;
                        }
                    if (char.IsUpper{ password[i]})
                    {
                isUpper = true;
            }
            if (char.isNumber{ password[i]})
                    { isNumber = true;
            }

            if (IsLower && upper && isNumber)
            {
                return true;
            }
            else
            { return false; }
        }
        public char GetFirstLetterOfString(string str)
        {
            return str[0];
        }
        public char GetLastLetterOfString(string str)
        {
            return str.last();
        }

        public decimal Divide(decimal dividend, decimal divisor, decimal expected)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        [Fact]
        public int ShouldGetOddsBelow100()
        { List<int> nums = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (i % 2 != 0)
                {
                    nums.Add(i);
                }
            }

            public void ChangeAllElementsToUppercase(string[] values, string[] expected)
            {
                { for (int i = 0; i < values.Length; i++)
                    {
                        words[i] = words[i].ToUpper();
                    }
                }
            }
        }
    }
}

