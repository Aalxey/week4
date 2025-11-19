using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks obtained: ");
            int marks;
            while (!int.TryParse(Console.ReadLine(), out marks))
            {
                Console.WriteLine("Invalid input! Enter a valid integer.");
            }

            Console.Write("Enter total marks: ");
            int total;
            while (!int.TryParse(Console.ReadLine(), out total))
            {
                Console.WriteLine("Invalid input! Enter a valid integer.");
            }

            double percentage = marks / total * 100; 

            Console.WriteLine("Percentage: " + percentage + "%");

        }
    }
}
