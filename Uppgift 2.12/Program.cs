namespace Uppgift_2._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startCost = 300;
            int perKM = 1;
            int perDay = 500;

            Console.WriteLine("How many days do you want to rent the car and how many KM will you drive?");
            Console.Write("Days: ");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.Write("KM: ");
            int kM = Convert.ToInt32(Console.ReadLine());

            int totalCost = startCost + ((days - 1) * perDay) + (kM * perKM);
            Console.WriteLine($"Your total cost will be: {totalCost} kr");

        }
    }
}