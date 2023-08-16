namespace _2._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the monthly salary of three employees: ");
            Console.Write("#1: ");
            double salaryOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("#2: ");
            double salaryTwo = Convert.ToDouble(Console.ReadLine());
            Console.Write("#3: ");
            double salaryThree = Convert.ToDouble(Console.ReadLine());
            //såhär
            double averageSalary = (salaryOne + salaryTwo + salaryThree) / 3 ;
            Console.WriteLine("The average salary of the employees is: " + averageSalary);
            //eller såhär
            Console.WriteLine($"The average salary of the employees is: {(salaryOne + salaryTwo + salaryThree) / 3}");

        }
    }
}