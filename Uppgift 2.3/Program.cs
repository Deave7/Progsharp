namespace Uppgift_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How high can you jump in meters?");
            double jumpHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The worldrecord for highjump is {jumpHeight - 2,45}m higher than you");

        }
    }
}