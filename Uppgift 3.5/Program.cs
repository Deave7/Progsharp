namespace Uppgift_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Hur gammal är du?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hur mycket tjänar du på en månad?");
            int salary = Convert.ToInt32(Console.ReadLine());

            if (age == 39)
            {
                Console.WriteLine("Du är lika gammal som medelpersonen i Göteborg");
            }
            else if (age > 39)
            {
                Console.WriteLine("Du är äldre än medelpersonen i Göteborg");
            }
            else if (age < 39)
            {
                Console.WriteLine("Du är yngre än medelpersonen i Göteborg");
            }

            if (salary == 36100)
            {
                Console.WriteLine("Du tjänar lika mycket som medellönen i Sverige");
            }
            else if (salary > 36100)
            {
                Console.WriteLine("Du tjänar mer än medellönen i Sverige");
            }
            else if (salary < 36100)
            {
                Console.WriteLine("Du tjänar mindre än medellönen i Sverige");
            }


        }
    }
}