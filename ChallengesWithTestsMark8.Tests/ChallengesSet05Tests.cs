using System;
using System.Collections.Generic;
using Xunit;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet05Tests
    {

        public int NextNumberDivisibleByN(int startNumber, int n, int expected)
        {
            if (startNumber == 0)]
            {
                return n;
            }
            List<int> firstlist = new List<int>();
            int maxLoop = startNumber * n;
            int[] numberDivisiblebyN = new int[0];
            for (int i = 0; i < maxLoop, i++)
            {
                if (i > startNumber && i % n == 0)
                {
                    result = 1;
                    break;
                }
            }
            return reuslt;
        }

        public bool ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(string[] names, double[] revenues)
        {
            // Arrange
            ChallengesSet05 challenger = new ChallengesSet05();
            Business[] businesses = new Business[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                };
            }
        }
        // Act

        public int IsAscendingOrder(int[] nums, bool expected)
        { if (numbers == null || numbers.length == 0)
            {
                return false;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }


        public int SumElementsThaFollowAnEven(int[] numbers, int expected)
        {
            if (numbers == null || numbers.length == 0)
            {
                sum += numbers[i];
            }
        }
            return sum;
    }
    public string TurnWordsIntoSentence(string[] words, string expected)
    {
        if (words == null || words.Length == 0)
        {
            return "";
        }

        string sentence = "";

        foreach (string word in words)
        {
            if (word.Trim().Length > 0)
            {
                sentence += word.Trim() + " ";
            }
        }

        if (sentence.Length == 0)
        {
            return "";
        }

        sentence = sentence.Substring(0, sentence.Length - 1);
        sentence += ".";
        return sentence;
    }
    public double GetEveryFourthElement(double[] numbers, double[] expected)
    {
        if (numbers == null || elements.count == 0)
        {
            return new double[0];
        }
        List<double> everyFourth = new List<double>();
        for (int i = 3; i < elements.Count; i += 4)
        {
            everyFourth.Add(elements[i]);
        }
        return everyFourth.ToArray();
    }

    public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] numbers, int targetNumber, bool expected)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (nums[i] + nums[k] == targetNumber)
            }
            return true;
        }
    }
}
    return false;
        }
    }
}