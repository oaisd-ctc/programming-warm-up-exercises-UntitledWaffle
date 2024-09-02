using System;
using System.ComponentModel.DataAnnotations;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string waf, waffle;

            waf = "Waffle";
            waffle = "waf";

            Console.WriteLine(waf);
            Console.WriteLine(waffle);

            Add(1, 2);
            IsEven(1);
            IsEven(2);
            MaxOfThree(3, 2, 1);
            StringLength("HEEEEELP HEEEELP");
            StartsHello(" Hello, Ms. Sofia");
            StartsHello(" Mr. President");
            StartsHello("Hello");
            ReverseString("Walmart");
            Console.WriteLine(Factorial(3));
            Console.WriteLine(IsPrime(2));
            Console.WriteLine(IsPrime(3));
            Console.WriteLine(IsPrime(4));
            Console.WriteLine(IsPrime(5));
            Console.WriteLine(Fibonacci(9));
            Console.WriteLine(IsPalindrome("racecar"));
            Console.WriteLine(IsPalindrome("waffle"));
            CharCount("wattaer",'a');
            SwapEnds("Nixon");
            ConcatenateStrings("I am", " el president");
            // The Ez section

            // The "Free Bird" Section: https://www.youtube.com/watch?v=EUc1AhTdG3U&t=48s
            int[] numbers = {1, 2, 3, 4};
            int[] RAHHHHHH = {4, 3, 4, 6, 20, 40, 1, 60, 100, 120, 6};
            Console.WriteLine(LargestInArray(numbers));
            Console.WriteLine(LargestInArray(RAHHHHHH));
            int[] WAHHHH = {1, 2, 3, 4};
            int[] Donald = {1, 2, 3, 6};
            Console.WriteLine(ArraySum(WAHHHH));
            Console.WriteLine(ArraySum(Donald));
            string pancake = "DIE COMMIE SCUM! XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX xxxxx XXX x / xxx";
            char syrup = 'X';
            int count = CharCount(pancake, syrup);
            Console.WriteLine($"The character '{syrup}' kills {count} commies within the string.");
            //'X' is a red herring, get pranked!

        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            Console.WriteLine(a+b);
            return 0;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            if (number % 2==0)
            {
                Console.WriteLine(number + " Number is even");
            }
            else
            {
                Console.WriteLine(number + " Number is odd");
            }
            return true;
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            
            Console.WriteLine(Math.Max(a, Math.Max(b, c)));
            return Math.Max(a, Math.Max(b, c));
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            
            Console.WriteLine(s + " HEEEEEEEEEEELPPPPPPPPPPP HePL ME!" + s.Length);
            return 0;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            Console.WriteLine((s.Length < 6 && s.Equals("Hello")) || ( s.StartsWith(" Hello") && s[5] == ' '));
            return true;
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            int Length = charArray.Length;
            for( int i = 0; i < Length / 2; i++){
            char temp = charArray [i];
            charArray [i] = charArray[Length - i - 1];
            charArray[Length - i - 1] = temp;
            }
            Console.WriteLine(charArray);
            return new string(charArray);
            
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            
            return n * Factorial(n - 1);
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;

            else {
                return Fibonacci (n-1) + Fibonacci(n-2);


            }
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - i - 1])
                return false;

            }
            return true;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = numbers.Sum();
            return sum;
        }
        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = s.Count(f => f == ' ');
            

            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            Console.WriteLine(str1 + str2);
            return str1 + str2;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            string middlepart = s.Substring(1, s.Length - 2);
            Console.WriteLine(lastChar + middlepart+ firstChar);
            return lastChar + middlepart+ firstChar;
        }
    }
}
