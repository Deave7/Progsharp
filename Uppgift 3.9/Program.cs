namespace Uppgift_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence!");
            string sentence = Console.ReadLine();

            if (sentence.Contains('+') && !sentence.Contains('-'))
            {
                Console.WriteLine("The sentence contains a + sign.");
            }
            else if (sentence.Contains('-') && !sentence.Contains('+'))
            {
                Console.WriteLine("The sentence contains a - sign.");
            }
            else if (sentence.Contains('+') &&  sentence.Contains('-'))
            {
                Console.WriteLine("The sentence contains a - and a + sign.");
            }
            else
            {
                Console.WriteLine("The sentence does not contain a - and a +");
            }
        }
    }
}