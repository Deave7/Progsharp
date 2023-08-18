namespace Uppgift_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge >= 50)
            {
                Console.WriteLine("You're allowed to join the senior tournament!");
            }
            else
            {
                Console.WriteLine("You're not old enough to join the senior tournament :(");
            }
        }
    }
}