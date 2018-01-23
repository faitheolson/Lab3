using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine();

            while (repeat == true)
            {
                Console.WriteLine("Please enter a positive integer!");
                int Input = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.Write("Number");
                Console.SetCursorPosition(14, 0);
                Console.Write("Squared");
                Console.SetCursorPosition(30, 0);
                Console.WriteLine("Cubed");
                Console.SetCursorPosition(0, 1);
                Console.Write("======");
                Console.SetCursorPosition(14, 1);
                Console.Write("======");
                Console.SetCursorPosition(30, 1);
                Console.WriteLine("======");
                Console.WriteLine();

                for (int i = 1; i <= Input; i++)
                {
                    Console.SetCursorPosition(0,i+2);
                    Console.Write(i);
                    Console.SetCursorPosition(14, i + 2);
                    Console.Write(i*i);
                    Console.SetCursorPosition(30, i + 2);
                    Console.Write(i*i*i);
                }

                Console.WriteLine();

                Console.WriteLine("Would you like to continue? (y/n)");
                string Again = Console.ReadLine();

                if (Again != "Y" && Again != "y")
                {
                    repeat = false;
                    Console.WriteLine("Goodbye!");
                }

            }

        }
    }
}
