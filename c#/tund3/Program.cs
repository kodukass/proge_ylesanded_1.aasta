using System;
class Massiiv1
{
    public static void Main(string[] arg)
    {

        //int[,] tabel = new int[3, 6];
        //tabel[2, 2] = 17;
        //for (int i = 0; i < tabel.GetLength(0); i++)
        //{
        //    for (int j = 0; j < tabel.GetLength(1); j++)
        //    {
        //        Console.Write($"{tabel[i, j],5}");
        //    }
        //    Console.WriteLine();
        //}
        //int[,] ruut =
        //{
        //    {1,2,3 },
        //    {4,5,6 },
        //    {7,8,9 }
        //};
        //int[][] massiivideMassiiv =
        //{
        //    new int[]{1,2,3},
        //    new int[]{4,5,6,7,8,9},
        //};
        //int arv = 5555;
        //int arv2 = arv;
        //string[] nimed = { "jaan", "jaanika","juss","julia" };
        //string[] kohad = nimed;
        //Console.WriteLine(kohad[0]);
        //Console.WriteLine(nimed[0]);
        //kohad=(string[])nimed.Clone();
        //kohad[0] = "Teet";
        //Console.WriteLine(kohad[0]);
        //Console.WriteLine(nimed[0]);
        //Array.Clear(kohad, 0, kohad.Length); //Tühjendus
        //foreach (var koht in kohad)
        //{
        //    //var koht=kohad[0];
        //    Console.WriteLine(koht); //koht.Length annab errori. sõne default on null
        //}
        //nimed[0] = "julia";
        //Console.WriteLine($"julia asub: {Array.IndexOf(kohad, "julia")}");
        //Console.WriteLine($"julia asub: {Array.IndexOf(nimed, "julia")}"); //puuduv element annab tulemuseks -1

        //LisaTervitus(nimed);
        //KuvaMasiiv(nimed);


        //int[] m = new int[3];
        //m[0] = 40;
        //m[1] = 48;
        //m[2] = 33;
        //KuvaSummaTehe(m);
        //int[] arvud = new int[] {1,3,2,4,5,6,7,8,6,0};
        //KuvaSummaTehe(arvud);
        //Array.Sort(arvud);
        //KuvaSummaTehe(arvud);

        //}

        //private static void KuvaMasiiv(string[] array)
        //{
        //    foreach (var item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //private static void LisaTervitus(string[] nimed)
        //{
        //    for (int i = 0; i < nimed.Length; i++)
        //    {
        //        nimed[i] ="tere,"+nimed[i];
        //    }

        //}

        //private static void KuvaSummaTehe(int[] m)
        //{
        //    int summa = 0;
        //    for (int i = 0; i < m.Length; i++)
        //    {
        //        Console.Write(m[i] + "+");
        //        if (i < m.Length - 1)
        //        {
        //            Console.Write("+");
        //        }
        //        summa += m[i];
        //    }
        //    Console.WriteLine(summa);
        //}


        //* Küsi kasutaja käest viis arvu ning väljasta need tagurpidises järjekorras.

        private static void Main1(string[] arg)
        {
            int[] arvud = new int[5];
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"Sisesta {i + 1}. täisarv");
                arvud[i] = int.Parse(Console.ReadLine());
            }
            //Array.Reverse(arvud);

            Console.WriteLine("tagurpidi arvud");
            for (int i = arvud.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arvud[i]);
            }

        }

        //* Loo alamprogramm massiivi väärtuste aritmeetilise keskmise leidmiseks.Katseta.
        double keskmine = LeiaKeskmine(arvud);
        Console.WriteLine($"{keskmine}");
        Console.WriteLine(arvud.Average());
    }
        private static double leiaKeskmine(int[]massiiv)
        {
            long summa = 0;
            for (int i = 0;i<massiiv.Length; i++)
            {
                summa+=massiiv[i];
            }
            return(double)summa/massiiv.Length;
        }
    //* Loo alamprogramm, mis suurendab kõiki massiivi elemente ühe võrra.Katseta.
        LisaIgaleKaks(arvud);
        private static void LisaIgaleKaks(int[]arvud)
    {
        for (int i = 0;i<arvud ; i++)
        { }
    }
    static void Tryki(int[]mas)
    {
        for (int i = 0; i<mas.Length; i++)
        {
            Console.Write(mas[i]+".";
        }
    }
        //* Sorteeri massiiv ning väljasta selle keskmine element.

        public static void Main(string[] arg)
        {
            int[] m = new int[5] { 2, 1, 5, 4, 3 };
            Array.Sort(m);
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i]);
            }
            Console.WriteLine($"keskmine element on {m[2]}");
        }

        //* Koosta kahemõõtmeline massiiv ning täida korrutustabeli väärtustega.Küsi massiivist kontrollimiseks väärtusi.

        public static void Main1(string[] arg)
        {
            int[,] m = new int[2, 4]{
             {1, 2, 3, 4},
             {2, 4, 6, 8}
           };
            Console.WriteLine("rea number (0-1):");
            string rida = Console.ReadLine();
            int r = int.Parse(rida);
            Console.WriteLine("veeru number (0-3):");
            string veerg = Console.ReadLine();
            int v = int.Parse(veerg);

            Console.WriteLine(m[r, v]);

        }
    }
}

