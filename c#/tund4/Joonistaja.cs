using System;

namespace tund4
{
    internal class Joonistaja
    {
        internal static void TeeRuut()
        {
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0, 2}", "*");
                }
                Console.WriteLine();
            }
        }
        internal static void TeeJoon()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}