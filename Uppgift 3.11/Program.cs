namespace Uppgift_3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj en frågekategori.");
            Console.WriteLine("1. Musik");
            Console.WriteLine("2. Geografi");
            Console.WriteLine("3. Historia");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Vilket band är bäst i världen?");
                    string answer = Console.ReadLine();

                    if (answer.ToLower() == "queen")
                    {
                        Console.WriteLine("Rätt svar! Bästa bandet i världen är Queen!");
                    }
                    else
                    {
                        Console.WriteLine("Fel svar! Rätt svar är Queen!");
                    }
                    break;

                case 2:
                    Console.WriteLine("Vad heter Österrikes huvudstad?");
                    answer = Console.ReadLine();

                    if (answer.ToLower() == "wien")
                    {
                        Console.WriteLine("Rätt svar! Österrikes huvudstad heter Wien!");
                    }
                    else
                    {
                        Console.WriteLine("Fel svar! Rätt svar är Wien!");
                    }
                    break;

                case 3:
                    Console.WriteLine("När slutade andra världskriget?");
                    answer = Console.ReadLine();

                    if (answer.ToLower() == "1939")
                    {
                        Console.WriteLine("Rätt svar! Andra världskriget slutade 1939!");
                    }
                    else
                    {
                        Console.WriteLine("Fel svar! Rätt svar är 1939!");
                    }
                    break;
            }
        }
    }
}