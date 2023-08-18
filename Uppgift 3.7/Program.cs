namespace Uppgift_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());

            if (age > 10 && age <= 18 && age >= 65)
            {
                Console.WriteLine("Grattis, du får köpa billigare kaffe!");
            }
            
        }
    }
}