namespace Uppgift_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What city are you from?");
            string city = Console.ReadLine();
            Console.WriteLine("What's your dream destination?");
            string destination = Console.ReadLine();

            Console.WriteLine($"Hello {city}er, I hope you get to go to {destination}.");
        }
    }
}