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
                long Input = long.Parse(Console.ReadLine());

                int Column = Console.CursorLeft;
                int Line = Console.CursorTop;

                Console.SetCursorPosition(Column, Line);
                Console.Write("Number");
                Console.SetCursorPosition(Column + 14, Line);
                Console.Write("Squared");
                Console.SetCursorPosition(Column + 30, Line);
                Console.WriteLine("Cubed");
                Console.SetCursorPosition(Column, Line + 1);
                Console.Write("======");
                Console.SetCursorPosition(Column + 14, Line + 1);
                Console.Write("======");
                Console.SetCursorPosition(Column + 30, Line + 1);
                Console.WriteLine("======");
                Console.WriteLine();

                SquaresCubes(Input);

                Console.WriteLine();

                Console.WriteLine("Would you like to continue? (y/n)");
                string Again = Console.ReadLine();

                if (Again != "Y" && Again != "y")
                {
                    repeat = false;
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                }

            }

        }

        public static void SquaresCubes(long Input)
        {
            for (int i = 1; i <= Input; i++)
            {
                int Column = Console.CursorLeft;
                int Line = Console.CursorTop;
                Console.SetCursorPosition(Column, Line);
                Console.Write(i);
                Console.SetCursorPosition(Column + 14, Line);
                Console.Write(Squared(i));
                Console.SetCursorPosition(Column + 30, Line);
                Console.WriteLine(Cubed(i));
            }
        }

        public static long Squared(long i)
        {
            return (i * i);
        }

        public static long Cubed(long i)
        {
            return (i * i * i);
        }
    }
}
