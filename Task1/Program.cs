namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Name = "Ram";
            Console.WriteLine(std.Name);

            Student stud = new Student();
            stud.Name = "Hari";
            Console.WriteLine(stud.Name);

            Student.marks = 40;
            Console.WriteLine(Student.marks);
        }
    }
}
