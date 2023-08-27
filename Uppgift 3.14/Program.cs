namespace Uppgift_3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Did you graduate highschool? y/n");
            string answer = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            if (answer.ToLower() == "y" && age < 22)
            {
                Console.WriteLine("We would love to hire you!");
            }
            else
            {
                Console.WriteLine("We are looking for a different kind of person at the moment");
            }
        }
    }
}