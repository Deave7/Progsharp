namespace Uppgift_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What year is it? ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"In twenty years the year till be {year + 20}");
        }
    }
}