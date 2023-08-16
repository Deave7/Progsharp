namespace Uppgift_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year is it?");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine($"It's {2100 - year} years left until the year of 2100.");
        }
    }
}