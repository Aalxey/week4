namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParameterDemo pde = new ParameterDemo();

            int number = 100;
            Console.WriteLine(pde.increase(ref number));

            string fullName;
            Console.WriteLine(pde.GetFullName(out fullName));

            Console.WriteLine(pde.SumAll(1, 2, 3, 4, 5));
        }
    }
}
