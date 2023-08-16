namespace Uppgift_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            int mumTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The sum of your numbers is: {numOne +  mumTwo}");
        }
    }
}