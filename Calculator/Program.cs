using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0; int n2 = 0;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Type a number, and then press Enter");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a number, and then press Enter");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t1 - Add");
            Console.WriteLine("\t2 - Subtract");
            Console.WriteLine("\t3 - Multiply");
            Console.WriteLine("\t4 - Divide");
            Console.Write("Your option? ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"Your result: {n1} + {n2} = " + (n1 + n2));
                    break;
                case 2:
                    Console.WriteLine($"Your result: {n1} - {n2} = " + (n1 - n2));
                    break;
                case 3:
                    Console.WriteLine($"Your result: {n1} * {n2} = " + (n1 * n2));
                    break;
                case 4:
                    Console.WriteLine($"Your result: {n1} / {n2} = " + (n1 / n2));
                    break;

            }
        }
    }
}
