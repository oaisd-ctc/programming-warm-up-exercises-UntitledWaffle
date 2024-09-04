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
            // 1. Adds two ints
            IsEven(1);
            IsEven(2);
            IsEven(27);
            IsEven(16);
            // 2. Checks if number is odd or even by dividing it in half.
            MaxOfThree(3, 2, 1);
            // 3. Looks for the largest number
            StringLength("HEEEEELP HEEEELP");
            // 4. Returns the length of a given string
            StartsHello(" Hello, Ms. Sofia");
            StartsHello(" Mr. President");
            StartsHello("Hello");
            StartsHello("Hello Ms. Sofia");
            // 5. Checks if Hello is in the beginning of a statement
            ReverseString("Walmart");
            // 6. Reverse the whole string
            Console.WriteLine(Factorial(3));
            Console.WriteLine(Factorial(4));
            // 7. Uses Factorial method to find Factorials! And prints them to the console.
            Console.WriteLine(IsPrime(2));
            Console.WriteLine(IsPrime(3));
            Console.WriteLine(IsPrime(4));
            Console.WriteLine(IsPrime(5));
            // 8. Divides number by 2 and if the number = 0 then it is a prime, otherwise it's an odd number
            Console.WriteLine(Fibonacci(9));
            // 9. First checks if the number can be used, then uses the fibonacci method 
            Console.WriteLine(IsPalindrome("racecar"));
            Console.WriteLine(IsPalindrome("waffle"));
            // 11. Flips the words backwords and checks if it's the same word or not
            SwapEnds("Nixon");
            // 15. Cuts of the first and last letters and swaps them around
            ConcatenateStrings("I am", " el president");
            // 14. Adds two strings into a single string

            // This was the Ez section

            // The "Free Bird" Section: https://www.youtube.com/watch?v=EUc1AhTdG3U&t=48s
            int[] numbers = { 1, 2, 3, 4 };
            int[] RAHHHHHH = { 4, 3, 4, 6, 20, 40, 1, 60, 100, 120, 6 };
            Console.WriteLine(LargestInArray(numbers));
            Console.WriteLine(LargestInArray(RAHHHHHH));
            // 10. an algorithm searches through the whole area looking for the biggest number
            int[] WAHHHH = { 1, 2, 3, 4 };
            int[] Donald = { 1, 2, 3, 6 };
            Console.WriteLine(ArraySum(WAHHHH));
            Console.WriteLine(ArraySum(Donald));
            // 12. Adds all ints in an array
            string pancake = "DIE COMMIE SCUM! XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX xxxxx XXX x / xxx";
            char syrup = 'X';
            int count = CharCount(pancake, syrup);
            Console.WriteLine($"The character '{syrup}' kills {count} commies within the string.");
            //'X' is a red herring, get pranked! 
            // 13. This one is a little bit of a prank, but it searches the string for a specific char; The char not being used from the Main but in the function. To fix it
            // simply replace the ' ' with c and the char in main will work

        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            Console.WriteLine(a + b);
            return 0;
        }
        // Takes both the ints and adds them and writes them directly to the Console

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " Number is even");
            }
            else
            {
                Console.WriteLine(number + " Number is odd");
            }
            return true;
        }
        // Divides the number by 2 with the % divider which doesn't use decimals which makes the answer either something or 0, if number is zero then it is even and the opposite
        // for the something answer

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {

            Console.WriteLine(Math.Max(a, Math.Max(b, c)));
            return Math.Max(a, Math.Max(b, c));
        }
        // Grabs three ints and using the Math.Max method directly sends the answer into the Console

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {

            Console.WriteLine(s + " HEEEEEEEEEEELPPPPPPPPPPP HePL ME! " + s.Length);
            return 0;
        }
        // Adds a string to another one and the code checks the first string for the amount of chars in it

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            Console.WriteLine((s.Length < 6 && s.Equals("Hello")) || (s.StartsWith("Hello") && s[5] == ' '));
            return true;
        }
        // Checks whether a string starts with the string "Hello" and the amount of chars used in it; though it may not have punctuation. 

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            int Length = charArray.Length;
            for (int i = 0; i < Length / 2; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[Length - i - 1];
                charArray[Length - i - 1] = temp;
            }
            Console.WriteLine(charArray);
            return new string(charArray);
        }
        //Turns the string into an array of chars then it flips them around, then it grabs the answer and displays it on the console

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n == 0) return 1;

            return n * Factorial(n - 1);
        }
        // Checks if the input is zero, if it is then it returns 1; Otherwise it does the math and sends it to main to be printed

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
        // Checks if number is not a negative or 0, then it takes the number and divides it by; If it doesn't equal 0 then it is a prime

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;

            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        // Takes the int and checks if it's a negative number or 0, then it does the fibonacci stuff

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
        // Takes the array of numbers and checks the array for the largest number

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
        // Goes through the string and 

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
            Console.WriteLine(lastChar + middlepart + firstChar);
            return lastChar + middlepart + firstChar;
        }
    }
}
