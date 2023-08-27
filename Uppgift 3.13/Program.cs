namespace Uppgift_3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int answer = int.Parse(Console.ReadLine());

            if (answer >= 16 &&  answer <= 19)
            {
                Console.WriteLine("You are eligible to compete");
            }
            else if (answer < 16)
            {
                Console.WriteLine("You are to young to compete");
            }
            else
            {
                Console.WriteLine("You are too old to compete");
            }
        }
    }
}