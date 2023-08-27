
namespace Uppgift_3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många datorer äger du?");
            int antalDatorer = int.Parse(Console.ReadLine());

            string answer = antalDatorer == 1 ? "Du äger 1 dator" : "Du äger " + antalDatorer + " datorer";
            Console.WriteLine(answer);


        }
    }
}