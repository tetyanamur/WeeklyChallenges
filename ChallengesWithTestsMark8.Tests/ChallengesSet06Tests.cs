using System;
using System.Collections.Generic;
using Xunit;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet06Tests
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase, bool expected)
        { bool contains word = false;
            {
                if (string.Equals(words, null) || word.Contains(null))
                {
                    return false;
                }
                if (ignoreCase == true)
                    word = word.ToLower();
                List<string> lc = words.Select(x => x.ToLower()).ToList();

                containsWord = lc.Contains(word);
            }
            if (ignoreCase == false)
            {
                containsWord = word.Contains(word);
            }
            return ContainsWord;
        }


        public bool IsPrimeNumber(int number, bool expected)
        {
            var isPrime = false;
            if (num >= 0)
            {
                if (num % 2 != && number % 3 != 0)
                {
                    isPrime = false;
                }
                return isPrime;

            }

            public int LastUniqueIndex(string str, int expected)
            {
                int index = -1;
                bool unidex;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[1] == str[j] && != j)
                    {
                        unidex = false;
                    }
                }
                if (unidex = true)
                {
                    index = i;
                }
            }
            return index;


        }

        }

    public int MaxConsecutiveCount(int[] numbers, int expected)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentCount = 1;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] != numbers[j] && i != j)
                {
                    break;
                }
                currentCount++;
            }
            if (currentCount > count)
            {
                count = currentCount;
            }
        }


        public double GetEveryNthElement_List(double[] numbers, int n, double[] expected)
        {
            List<double> nthElement = new List<double>();
            double[] nullCheck = new double[0];
            int count = 0;
            if (elements == null)
            {
                return nullCheck;
            }

            for (int i = 0; i < elements.count ; i++)
            {
              if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }
                  
                }
                if (n>0 || n > elements.Count)
            {
                nthElement.Clear();
            }
            double[] finalArray = nthElement.ToArray();
            return finaArray;
            }
        }
    }