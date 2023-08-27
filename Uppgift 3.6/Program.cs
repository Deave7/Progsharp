namespace Uppgift_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur lång är du?");
            double height = Convert.ToDouble(Console.ReadLine());

            if (height >= 1.5 && height <= 1.9)
            {
                Console.WriteLine("Du är lång nog att åka berg-och-dalbanan!");
            }
            else
            {
                Console.WriteLine("Du är för kort eller för lång för att åka berg-och-dalbanan!");
            }
        }
    }
}