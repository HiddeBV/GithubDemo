using System;

namespace GithubDemo
{
    class InlineCompletionsDemo
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their name
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            // Greet the user
            Console.WriteLine($"Hello, {name}!");

            // Inline completion demo: Calculate the sum of two numbers
            // Prompt the user to enter the first number
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            // Prompt the user to enter the second number
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            // Calculate the sum of the two numbers
            int sum = num1 + num2;
            // Display the result
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");
        }
    }
}