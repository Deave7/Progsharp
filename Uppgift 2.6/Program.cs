namespace Uppgift_2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers: ");
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());

            Console.WriteLine($"The mean value of your numbers are {(numOne + numTwo) / 2} ");
        }
    }
}