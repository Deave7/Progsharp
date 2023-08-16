namespace Uppgift_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentance (without a dot)");
            string sentence = Console.ReadLine();

            int indexOfSpace = sentence.IndexOf(" ");
            string wordOne = sentence[0..indexOfSpace];
            string wordTwo = sentence[(indexOfSpace + 1)..];


            Console.WriteLine($"{wordTwo} {wordOne}");

        }
    }
}