namespace Uppgift_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What country won the womens soccer worldcup year 2015?");
            string userInput = Console.ReadLine();

            if (userInput.ToUpper() == "USA")
            {
                Console.WriteLine("DING DING! Your answer was correct! :)");
            }
            else
            {
                Console.WriteLine("Sorry, your answer was incorrect :(");
            }

        }
    }
}