namespace Uppgift_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många poäng fick du på nationella provet i matte?");
            int points = Convert.ToInt32(Console.ReadLine());

            if (points >= 55)
            {
                Console.WriteLine("Grattis! Du fick A i betyg!");
            }
            else if (points < 55 &&  points >= 46)
            {
                Console.WriteLine("Grattis! Du fick betyget B");
            }
            else if (points < 46 &&  points >= 35)
            {
                Console.WriteLine("Grattis! Du fick betyget C");
            }
            else if (points < 35 && points >= 27)
            {
                Console.WriteLine("Grattis! Du fick betyget D");
            }
            else
            {
                Console.WriteLine("Grattis! Du fick betyget E");
            }

        }
    }
}