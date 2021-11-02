using System;

namespace Vëk
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.BackgroundColor = (ConsoleColor.DarkMagenta);
                Console.ForegroundColor = (ConsoleColor.Blue);
                Console.BackgroundColor = (ConsoleColor.Black);
                Ram1(0, 0);
                Ram2(0, 6);
                Console.SetCursorPosition(24, 3);
                Console.WindowWidth = (135);
                Console.WindowHeight = (23);
                double rok = double.Parse(Console.ReadLine());
                var datum = DateTime.Now.Year;
                var věk = datum - rok;
                Console.SetCursorPosition(14, 7);
                Console.Write(věk);

                Console.SetCursorPosition(11, 9);

                if (věk < 0)
                {
                    Console.WriteLine("nenarozen");
                }
                if (věk < 6! & 0 > věk)
                {
                    Console.Write("dite");
                }
                if (věk > 6! & 15 > věk)
                {
                    Console.Write("zak");
                }
                if (věk > 15! & 19 > věk)
                {
                    Console.Write("stredoskolak");
                }
                if (věk > 19! & 24 > věk)
                {
                    Console.Write("vysokoskolak");
                }
                if (věk > 24! & 65 > věk)
                {
                    Console.Write("pracujici obcan");
                }
                if (věk > 65! & 100 > věk)
                {
                    Console.Write("duchodce");
                }
                if (věk > 100! & 112 > věk)
                {
                    Console.WriteLine("opravdu stary");
                }
                if (věk > 112)
                {
                    Console.WriteLine("Nejstarsí clovek");
                }

                Console.SetCursorPosition(0, 12);
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.WriteLine("█▌Zmacknete enter prosim         █▌");
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.ReadLine();
                Console.WindowWidth = (120);
                Main(null);

            }
            catch
            {
                Console.Clear();
                Main(null);
            }

        }
        static void Ram1(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("█▌Kalkulacka veku                 █▌");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("█▌Zadejte rok narozeni:           █▌");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

        }


        static void Ram2(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("█▌Vas věk:                        █▌");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("█▌Jste:                           █▌");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.SetCursorPosition(left + 14, top + 8);
        }

    }
}