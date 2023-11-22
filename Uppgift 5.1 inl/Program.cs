using System;
namespace Uppgfit_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 5 namn");
            string[] namn = new string[6];
            for (int i = 1; i <= 5; i++)
            {
                namn[i] = Console.ReadLine();
            }
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(namn[i]);
            }
            Console.Read();
        }
    }
}