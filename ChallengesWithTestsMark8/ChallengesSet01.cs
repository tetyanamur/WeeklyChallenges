using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        using System;
        {
            
            public bool AreTwoNumbersTheSame(int number1, int number2)
            {
                
                if (number1 == number2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            public double Subtract(double minuend, double subtrahend)
            {
               
                return minuend - subtrahend;
            }


            public int Add(int number1, int number2)

            {
                return number1 + number2;

            }
            public int GetSmallestNumber(int number1, int number2, int expected)
            {

                if (number1 > number2)
                {
                    return number2;

                }
                else if (number2 > number1)
                {
                    return number1;
                }

                else
                {
                    return expected;
                }
            }


            public long Multiply(long factor1, long factor2)
            {
                return factor1 * factor2;
            }

            public string GetGreeting(string personName)

            {
                return personName = "Tetyana";


            }


            public string GetHey()
            {
                return "Hey!";
            }
        }
    }

kdkkd 
