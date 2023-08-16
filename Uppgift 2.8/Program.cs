namespace Uppgift_2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a addition of two integers without spaces, ie: 1+1");
            string addition = Console.ReadLine();

            int indexOfPositive = addition.IndexOf("+");
            int numOne = Convert.ToInt32(addition[..indexOfPositive]);
            int numTwo = Convert.ToInt32(addition[indexOfPositive..]);

            Console.WriteLine($"The sum of your numbers is: {numOne + numTwo}");
        }
    }
}