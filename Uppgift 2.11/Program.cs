namespace Uppgift_2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how long Elin and Alma jumped while competing: ");
            Console.Write("Elin: ");
            double elinJump = Convert.ToDouble(Console.ReadLine());
            Console.Write("Alma: ");
            double almaJump = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Elin jumped {elinJump - almaJump} farther than Alma");
        }
    }
}