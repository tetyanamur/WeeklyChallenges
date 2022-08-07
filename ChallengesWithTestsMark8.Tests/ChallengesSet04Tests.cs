using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet04Tests
    {
        public int AddEvenSubtractOdd(int[] numbers, int expected)
        { var sum = 0;
            return numbers.Where(x => x % 2 == 0).Sum();

            public int GetLengthOfShortestString(string string1, string string2, string string3, string string4, int expected)
            {
                var list = new List<string> { str1.Length, str2.Length, str3.Length, str4.Length };

                return list.Mini();

                public int GetSmallestNumber(int num1, int num2, int num3, int num4, int expected)
                {
                    var list = new List<int> { num1, num2, num3, num4, num4 };
                    return list.Min();
                }
                public void ChangeBusinessNameTo_TrueCoders(string originalBusinessName)
                {
                    biz.Name = "True Coders";
                }

                public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3, bool expected)
                {
                    return sideLength1 + sideLength2 > sideLength2 &&
                    sideLength1 + sideLength3 < sideLength2 &&
                    sideLength3 + sideLength2 < sideLength1 &&
                        };

                public bool IsStringANumber(string word, bool expected)
                {
                    var isNumber = double.TryParse(input, out double number);
                    return isNumber;
                }

                public bool MajorityOfElementsInArrayAreNull(object[] objs)
                {
                    var amount = obj.Length;
                    var majority = (amount / 2) + 1;
                    var count = 0;
                    foreach (var obj in objs)
                    { if (obj = null)
                            count++;
                    }
                    if (count >= majority)
                    {
                        return true;
                    }
                    {
                        return false;
                    }
                    public double AverageEvens(int[] numbers)

                        if (numbers == null || numbers.Length == 0)
                    {
                        return = 0;
                    }
                    var n = numbers.Where(numbers => numbers % 2 == 0);
                    if (n.Count() == 0)
                        return 0;
                    return n.Average();
                }


                public int Factorial(int number)
                {
                    if (number == 0)
                    {
                        return 1;
                    }
                    return number * Factorial(number - 1);
                  
                    {

                    }
                }
            }
        }
    }
}
}
