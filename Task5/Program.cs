namespace Task5
{
    enum DayType
    {
        Weekday,
        Weekend
    }

    record Book(string title, string author, double price);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a day (e.g., Sunday): ");
            string inputDay = Console.ReadLine();

            DayType dayType;

            if (inputDay.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
                inputDay.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }

            Console.WriteLine("It is: " + dayType);

            Book book1 = new Book("C# Basics", "Bishal Rai", 25.50);

            Book book2 = book1 with { title = "Advanced C#", price = 40.75 };

            Console.WriteLine("\nFirst Book:");
            Console.WriteLine(book1);

            var (title, author, price) = book2;
            Console.WriteLine("\nSecond Book Deconstructed:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }
    }
}
