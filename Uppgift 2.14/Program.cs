namespace Uppgift_2._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a multiplication of two decimal numbers ie 1,1*2,2");
            string multiplication = Console.ReadLine();

            int index = multiplication.IndexOf("*");

            double numOne = Convert.ToDouble(multiplication[..index]);
            double numTwo = Convert.ToDouble((multiplication[(index + 1)..]));

            double result = numOne * numTwo;
            Console.WriteLine($"The result of your multiplication is: {result}");

        }
    }
}