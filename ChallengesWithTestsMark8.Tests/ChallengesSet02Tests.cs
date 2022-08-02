using System.Collections.Generic;
using Xunit;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet02Tests
    {
        [Fact]
        public bool CharacterIsALetter()
        {
            return CharacterIsALetter();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number, bool expected)
        { if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            public bool IsNumberOdd(int number, bool expected)
            { if (number % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                public double SumOfMinAndMax(IEnumerable<double> numbers, double expected)
                {
                    if (numbers == null || number.Count() == 0) //if null collection
                    {
                        return 0;
                    }
                    return numbers.Min() + numbers.Max();
                }

                public int GetLengthOfShortestString(string str1, string str2, int expected)
                { if (str1.Length < str2.Length)
                    {
                        return str1.Length;
                    }
                    else
                    {
                        return str2.Length;
                    }
                }
                public int Sum(int[] numbers)
                {
                    return numbers.Sum();
                    if (numbers == null)
                    {
                        return 0;
                    }
                    int sum = 0;
                    foreach (var num in numbers)
                    {
                        sum += num; ///sum = sum + num
                        // or //or for(int i =0; i<numbers.Length; i++)
                        //{
                        //sum += numbers[i];
                        //}
                        // return sum

                        public int SumEvens(int[] numbers, int expected)
                        {
                            if (numbers == null)
                            {
                                return 0;
                            }
                            var evenSum = 0;
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] % 2 == null)
                                {
                                    evenSum += numbers[i];
                                }
                            }
                            return evenSum;
                            //or Linq: return numbers.Where( => x % 2 == 0).Sum();

                            public int IsSumOdd(int[] numbers, bool expected)
                            {
                                if (numbers == null)
                                {
                                    return false;
                                }
                                return (numbers.Sum() % 2 != 0);
                            }
                            public long CountOfPositiveOddsBelowNumber(int number, int expected)
                            {
                                //if (number <= 0)
                                //{
                                  //  return 0;
                                //}
                              //  else
                               // {
                                //    return number / 2;
                                //}
                                long count = 0
                            for (long i = number; i >= 0; i--)
                                {
                                    if (i % 2 ! == 0)
                                    {
                                        count += i;
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

