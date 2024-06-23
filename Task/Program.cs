namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write(" Please Enter Your Name : ");
            string Name = Console.ReadLine() ?? "NA";
            Console.Write("Please Enter Your Age : ");
            int Age;
            int.TryParse(Console.ReadLine() ?? "0", out Age);
            Console.Write(" Please Enter Your Salary : ");
            double Salary;
            double.TryParse(Console.ReadLine() ?? "0", out Salary);
            Console.Clear();
            Console.Write($"Name is  {Name}");
            Console.Write($"Age is  {Age}");
            Console.Write($"Salary is  {Salary}");
            Console.Beep(343, 1000);




        }
    }
}
