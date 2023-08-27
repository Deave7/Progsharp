namespace Uppgift_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hej!, vad heter du? ");
            string name = Console.ReadLine();

            if (name.ToLower() == "stig")
            {
                Console.WriteLine("Grattis! Det är din namnsdag idag! :D");
            }
            else if (name.ToLower() == "abraham") 
            {
                Console.WriteLine("Otur! Imorgon är det din namnsdaG");
            }
            else
            {
                Console.WriteLine("Tyvärr är det inte din namnsdag idag :(");
            }
        }
    }
}