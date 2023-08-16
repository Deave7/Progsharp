namespace Uppgift_2._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a sentence with three words: ");
            string sentence = Console.ReadLine();

            int indexOne = sentence.IndexOf(" ");
            int indexTwo = sentence.IndexOf(" ", indexOne + 1);
            int indexThree = sentence.IndexOf(" ", indexTwo + 1);

            Console.WriteLine(sentence[indexTwo..indexThree] + sentence[..indexOne] + sentence[indexThree..]);

        }
    }
}