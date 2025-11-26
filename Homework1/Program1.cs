namespace Homework1_ACA_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number 1
            // Find the average of two numbers
            int a = 32;
            int b = 10;
            var average = (a + b) / 2.0;
            Console.WriteLine("Number 1");
            Console.WriteLine("The average of " + a + " and " + b + " is: " + average + "\n");

            //Number 2
            // Calculate the value of the expression y = -6x + 8 for x = 2.5

            double x = 2.5;
            var y = -6 * x + 8;
            Console.WriteLine("Number 2");
            Console.WriteLine("The value of the expression y = -6x + 8 for x = " + x + " is: " + y + "\n");

            //Number 3
            // Calculate the value of the expression y = -x + 4 for x = 9

            x = 9;
            y = -x + 4;
            Console.WriteLine("Number 3");
            Console.WriteLine("The value of the expression y = -x + 4 for x = " + x + " is: " + y + "\n");

            //Number 4
            // Convert temperature from Fahrenheit to Celsius

            double fahrenheit = 451;
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Number 4");
            Console.WriteLine(fahrenheit + "Fahrenheit is equal to " + celsius + "Celsius" + "\n");

            //Number 5
            // Calculate the value of the expression y = 2sin(a) for a = 60°

            double aInDegrees = 60;
            double aInRadians = aInDegrees * (Math.PI / 180);
            y = 2 * Math.Sin(aInRadians);
            Console.WriteLine("Number 5");
            Console.WriteLine("The value of the expression y = 2sin(a) for a = " + aInDegrees + "° is: " + y + "\n");

            //Number 6
            // Calculate the average of numbers from 1 to 100
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            average = sum / 100.0;
            Console.WriteLine("Number 6");
            Console.WriteLine("The average of numbers from 1 to 100 is: " + average + "\n");

            //Number 7
            // Find the count of odd numbers from 1 to 100
            int countOfOddNumbers = 0;
            for (int i = 1; i <= 100; i+=2)
            {
                countOfOddNumbers++;
            }
            Console.WriteLine("Number 7");
            Console.WriteLine("The count of odd numbers from 1 to 100 is: " + countOfOddNumbers + "\n");

            //Number 8
            // Declare a method that takes x and a as parameters and calculates the value of the function y = ax^3 + a/x at that point  
            double Calculate(double x, double a)
            {
                return a * Math.Pow(x, 3) + a / x;
            }
            Console.WriteLine("Number 8");
            Console.WriteLine("The value of the function y = ax^3 + a/x for x = 2 and a = 3 is: " + Calculate(2, 3) + "\n");

            //Number 9
            // Declare a method that takes an integer n as a parameter and calculates its factorial
            long Factorial(int n)
            {
                if (n < 0)
                {
                    return -1; // Factorial is not defined for negative numbers
                }
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                long result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
            Console.WriteLine("Number 9");
            Console.WriteLine("The factorial of 5 is: " + Factorial(5) + "\n");

            //Number 10
            // Declare a method that takes an integer n and returns the n-th member of the Fibonacci sequence

            int Fibonacci(int n)
            {
                if (n <= 0)
                {
                    return 0;
                }
                if (n == 1 || n == 2)
                {
                    return 1;
                }
                int previous = 1, current = 1, next = 0;
                for (int i = 3; i <= n; i++)
                {
                    next = previous + current;
                    previous = current;
                    current = next;
                }
                return current;
            }
            Console.WriteLine("Number 10");
            Console.WriteLine("The 10th member of the Fibonacci sequence is: " + Fibonacci(10) + "\n");

            //Number 11
            // Declare a method that takes an integer n and returns true/false depending on whether the number is prime

            bool IsPrime(int n)
            {
                if (n <= 1)
                {
                    return false;
                }
                if (n == 2)
                {
                    return true;
                }
                if (n % 2 == 0)
                {
                    return false;
                }
                for (int i = 3; i*i <= n; i+=2)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            Console.WriteLine("Number 11");
            Console.WriteLine("Is 29 prime? Answer: " + IsPrime(29));
            Console.WriteLine("Is 30 prime? Answer: " + IsPrime(30) + "\n");

            //Number 12
            // Declare a method that takes an integer n as a parameter and returns the sum of its digits
            int SumOfDigits(int n)
            {
                if (n < 0)
                {
                    n*= -1; // Make n positive if it's negative
                }
                int sumOfDigits = 0;
                while (n > 0)
                {
                    sumOfDigits += n % 10;
                    n /= 10;
                }
                return sumOfDigits;
            }
            Console.WriteLine("Number 12");
            Console.WriteLine("The sum of digits of 158 is: " + SumOfDigits(158) + "\n");

            // Additional problem
            // Declare a method that takes an integer n as a parameter and returns:
            // true if its digits are in strictly increasing order from left to right,
            // false otherwise.

            bool AreDigitsStrictlyIncreasing(int n)
            {
                if (n < 0)
                {
                    n *= -1; // Make n positive if it's negative
                }
                int previousDigit = 10; // Initialize to a value greater than any digit
                while (n > 0)
                {
                    int currentDigit = n % 10;
                    if (currentDigit >= previousDigit)
                    {
                        return false;
                    }
                    previousDigit = currentDigit;
                    n /= 10;
                }
                return true;
            }
            Console.WriteLine("Additional Problem");
            Console.WriteLine("Are the digits of 1234 strictly increasing? Answer: " + AreDigitsStrictlyIncreasing(1234));
            Console.WriteLine("Are the digits of 4489 strictly increasing? Answer: " + AreDigitsStrictlyIncreasing(4489));
            Console.WriteLine("Are the digits of 4361 strictly increasing? Answer: " + AreDigitsStrictlyIncreasing(4361));
        }
    }
}
