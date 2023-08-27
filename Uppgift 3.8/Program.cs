namespace Uppgift_3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three words, one per line!");
            Console.Write("1: ");
            string wordOne = Console.ReadLine();
            Console.Write("2: ");
            string wordTwo = Console.ReadLine();
            Console.Write("3: ");
            string wordThree = Console.ReadLine();

            if (wordOne == wordTwo && wordThree == wordOne)
            {
                Console.WriteLine("Du har skrivit samma ord tre gånger...");
            }
            else if (wordOne.CompareTo(wordTwo) < 0 && wordOne.CompareTo(wordThree) < 0)
            {
                Console.WriteLine($"The first word: {wordOne} comes first alphabetically");
            }
            else if (wordTwo.CompareTo(wordOne) < 0 && wordTwo.CompareTo(wordThree) < 0)
            {
                Console.WriteLine($"The second word: {wordTwo} comes first alphabetically");
            }
            else
            {
                Console.WriteLine($"The third word: {wordThree} comes first alphabetically");
            }
        }
    }
}