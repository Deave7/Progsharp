namespace PaulExempel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Gustav", "Frida", "Jad", "Nathalie", "Said", "Zackarias", "Davoud", "Mohamad" };

            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}