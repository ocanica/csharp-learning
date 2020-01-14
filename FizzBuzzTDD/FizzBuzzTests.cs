using System;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        /*[Fact]
        public void ReturnsEmptyString()
        {
            var fizzBuzz = Fizzle(3);
            var expected = "";
            Assert.Equal(expected, fizzBuzz);
        }

        [Fact]
        public void ReturnsFizz()
        {
            var fizzBuzz = Fizz(3);
            var expected = "1 2 Fizz";
            Assert.Equal(expected, fizzBuzz);
        }

        [Fact]
        public void ReturnsBuzz()
        {
            var fizzBuzz = Buzz(5);
            var expected = "1 2 3 4 Buzz";
            Assert.Equal(expected, fizzBuzz);
        }*/

        [Fact]
        public void ReturnsFizzBuzz()
        {
            var fizzBuzz = FizzBuzzle(15);
            var expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz";
            Assert.Equal(expected, fizzBuzz);
        }

        private string FizzBuzzle(int number)
        {
            var stringArr = new string[number];
            for (int i = 1; i <= number; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    stringArr[i - 1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    stringArr[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    stringArr[i - 1] = "Buzz";
                }
                else
                {
                    stringArr[i - 1] = $"{i}";
                }
            }

            return string.Join(" ", stringArr);
        }

        /*private string Buzz(int number)
        {
            var stringArr = new string[number];
            for(int i = 1; i <= number; i++)
            {
                if(i % 5 == 0)
                {
                    stringArr[i - 1] = "Buzz";
                } else
                {
                    stringArr[i - 1] = $"{i}";
                }
            }

            return string.Join(" ", stringArr);
        }

        private string Fizz(int number)
        {
            var stringArr = new string[number];
            for(int i = 1; i <= number; i++)
            {
                if(i % 3 == 0)
                {
                    stringArr[i - 1] = "Fizz";
                }
                else
                {
                    stringArr[i - 1] = $"{i}";
                }
            }

            return string.Join(" ", stringArr);
        }*/

        /*private string Fizzle(int vnumber)
        {
            return string.Empty;
        }*/
    }
}
