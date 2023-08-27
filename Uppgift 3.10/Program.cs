namespace Uppgift_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What place did you get at your last competition?");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1st":
                    Console.WriteLine("Congratulations, you recieved a gold medal!");
                    break;

                case "2nd":
                    Console.WriteLine("Congratulations, you recieved a silver medal!");
                    break;

                case "3rd":
                    Console.WriteLine("Congratulations, you recieved a bronze medal!");
                    break;

                default:
                    Console.WriteLine("Unfortunately you did not recieve a medal");
                    break;
            }

        }
    }
}