using System;

namespace tund1k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("nimi plz");
            //string nimi = Console.ReadLine();
            //if (nimi == "mari")
            //{
            //    Console.WriteLine("hahah");
            //}
            //else
            //{
            //    Console.WriteLine("kdb");

            //    // && and
            //    // || or
            //}
            //Console.WriteLine("vanus");
            //int vanus = int.Parse(Console.ReadLine());
            //if (vanus < 6 && vanus == 3)
            //{
            //    Console.WriteLine("hahah");
            //}
            //else
            //{
            //    Console.WriteLine("kdb");
            //}

            ////-------------------------------------//

            //decimal pirnihind = 1.7M;
            //Console.WriteLine("mitu pirni");
            //decimal kogus = decimal.Parse(Console.ReadLine());
            //decimal summa = kogus * pirnihind;
            //Console.WriteLine("kilekorr");
            //if (Console.ReadLine().ToLower() == "jah")
            //{
            //    summa += 0.7M;
            //}
            //Console.WriteLine($"kogusumma {summa}");

            ////--------------------------------------//

            //Console.WriteLine("temperatuur");
            //int temperatuur = int.Parse(Console.ReadLine());
            if (temperatuur > 18)
            {
                Console.WriteLine("hea temp");
            }
            else
            {
                Console.WriteLine("halb");
            }

            ////______________________________________//

            //Console.WriteLine("kui pikk sa oled");
            //int pikkus = int.Parse(Console.ReadLine());
            //if (pikkus > 180)
            //{
            //    Console.WriteLine("long boi");
            //}
            //else if (pikkus > 160)
            //{
            //    Console.WriteLine("keskmine");
            //}
            //else
            //{
            //    Console.WriteLine("haha short");
            //}

            ////---------------------------------------//

            //Console.WriteLine("kui pikk sa oled");
            //int pikkus1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("mis sugu sa oled");
            //string sugu = Console.ReadLine();
            //if (pikkus > 180 && sugu == "mees" || (pikkus > 170 && sugu == "naine"))
            //{
            //    Console.WriteLine("long");
            //}
            //else if (pikkus > 170 && sugu == "mees" || pikkus > 160 && sugu == "naine")
            //{
            //    Console.WriteLine("keskmine");
            //}
            //else if (pikkus > 160 && sugu == "mees" || pikkus > 150 && sugu == "naine")
            //{
            //    Console.WriteLine("lühike");
            //}

            //---------------------------------------------//

            //decimal piimahind = 1M;
            //decimal saiahind = 2M;
            //decimal leivahind = 3M;
            //Console.WriteLine("kas sa tahad piima, saia või leiba osta");
            //string toit = Console.ReadLine();

            //if (toit == "piima")
            //{
            //    Console.WriteLine("palju");
            //    decimal kogus1 = decimal.Parse(Console.ReadLine());
            //    decimal summa1 = kogus1 * piimahind;
            //    Console.WriteLine($"hind on {summa1}");
            //}
            //else if (toit == "leiba")
            //{
            //    Console.WriteLine("palju");
            //    decimal kogus1 = decimal.Parse(Console.ReadLine());
            //    decimal summa1 = kogus1 * piimahind;
            //    Console.WriteLine($"hind on {summa1}");
            //}
            //else if (toit == "saia")
            //{
            //    Console.WriteLine("palju");
            //    decimal kogus1 = decimal.Parse(Console.ReadLine());
            //    decimal summa1 = kogus1 * piimahind;
            //    Console.WriteLine($"hind on {summa1}");
            //}

            //------------------------------------------//

            //decimal piimahind = 1M;
            //decimal saiahind = 2M;
            //decimal leivahind = 3M;
            //decimal summa2 = 0;
            //Console.WriteLine("kas sa soovid piima");
            //if (Console.ReadLine().ToLower() =="jah")
            //{
            //    summa2 += piimahind;
            //}
            //Console.WriteLine("kas sa soovid leiba");
            //if (Console.ReadLine().ToLower() == "jah")
            //{
            //    summa2 += leivahind;
            //}
            //Console.WriteLine("kas sa soovid saia");
            //if (Console.ReadLine().ToLower() == "jah")
            //{
            //    summa2 += saiahind;
            //}
            //Console.WriteLine($"kokku {summa2}");

            //---------------KORDUSED----------------//

            //-while-//
            int loendur = 1;
            while (loendur <= 5)
            {
                Console.WriteLine($"tere {loendur}");
                loendur++;
            }
            //-for-//
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"tere {i + 1}");
            }
            //-foreach-//
            int[] arvud = { 1, 2, 3, 4, 5 };
            foreach (var arv in arvud)
            {
                Console.WriteLine($" kkeke {arv}");
            }
            //-dowhile-//
            int jrkNr = 0;
            do
            {
                Console.WriteLine($"tere {++jrkNr}");
            } while (jrkNr < 5);

            //------------------------------//

            //Trüki arvude ruudud ühest kahekümneni
            int loendur1 = 1;
            while (loendur1 <= 20)
            {
                Console.WriteLine($"number {loendur1 * loendur1}");
                loendur1++;
            }
            //Küsi kasutajalt viis arvu ning väljasta nende summa
            //int loendur2 = 1;
            //decimal summa4 = 0;
            //while (loendur2 <= 5)
            //{
            //    Console.WriteLine($"kirjuta number");
            //    int number = int.Parse(Console.ReadLine());
            //    summa4 += number;
            //    loendur2++;
            //}
            //Console.WriteLine($"{summa4}");
            //Ütle kasutajale "Osta elevant ära!".Senikaua korda küsimust, kuni kasutaja lõpuks ise kirjutab "elevant".
            
            
                decimal loendur3 = 0;
                Console.WriteLine($"osta elevant ära!");
                while (Console.ReadLine().ToLower() == "" && loendur > 0)
                {
                    Console.WriteLine($"osta elevant ära!");
                    if (Console.ReadLine().ToLower() == "elevant")
                    {
                        Console.WriteLine($"nice");
                    }
                    else
                    {
                    loendur3++;
                    }
                }
            
            
        }
    }
}
