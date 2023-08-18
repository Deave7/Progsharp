namespace Uppgift_2._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a sentence with three words that ends on a dot: ");
            string sentence = Console.ReadLine();

            int indexOne = sentence.IndexOf(" ");
            int indexTwo = sentence.IndexOf(" ", indexOne + 1);
            int indexThree = sentence.IndexOf(".");

            string wordOne = sentence[..indexOne];
            string wordTwo = sentence[(indexOne + 1)..indexTwo];
            string wordThree = sentence[(indexTwo + 1)..indexThree];
            char dot = sentence[indexThree];

            Console.WriteLine($"{wordThree} {wordOne} {wordTwo}{dot}");

        }
    }
}