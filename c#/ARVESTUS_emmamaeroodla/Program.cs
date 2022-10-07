using System;

namespace ARVESTUS_emmamaeroodla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hinne3_I();
            Hinne3_II();
            Hinne3_III();
            Hinne4_IV();
            Hinne5_B();
            //Hinne5_Punkt();
        }

        //private static void Hinne5_Punkt()
        //{
        //    string[] nimed = new string[5];
        //    for (int i = 0; i < nimed.Length; i++)
        //    {
        //        Console.WriteLine("Kirjutage nimi: ");
        //        nimed[i] = Console.ReadLine();
        //    }
        //    if (nimed[0] == "Mari" || nimed[4] == "Juku")
        //    {
        //        for (int i = 0; i < nimed.Length; i++)
        //        {
        //            Console.WriteLine(nimed[i]);
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 0;i < nimed.Length; i++)
        //        {
        //            Console.WriteLine(nimed[i]);
        //        }
        //    }
        //}

        private static void Hinne5_B()
        {
            Console.WriteLine("Kirjutage kuu: ");
            string kuu = Console.ReadLine();

            if (kuu == "jaanuar" || kuu == "veebruar" || kuu == "detsember")
            {
                Console.WriteLine($"{kuu} on talvekuu.");
            }
            else if (kuu == "märts" || kuu == "aprill" || kuu == "mai")
            {
                Console.WriteLine($"{kuu} on kevadkuu.");
            }
            else if (kuu == "juuni"|| kuu =="juuli"|| kuu =="august")
            {
                Console.WriteLine($"{kuu} on suvekuu.");
            }
            else
            {
                Console.WriteLine($"{kuu} on sügiskuu.");
            }
        }

        private static void Hinne4_IV()
        {
            Console.WriteLine("Kirjutage kuubi esimene külje pikkus: ");
            string sõna = Console.ReadLine();
            int arv1 = int.Parse(sõna);

            static int Arvuta(int arv1)
            {
                return (arv1*arv1) * 6;
            }
            Console.WriteLine($"Kuubi pindala on {arv1} * {arv1} * 6 ehk {Arvuta(arv1)}");

        }

        private static void Hinne3_III()
        {
            string[] tähtede_massiiv = new string[5] { "a", "b", "c", "d", "f"};
        }

        private static void Hinne3_II()
        {
            //for (int i = 0; i < length; i++)
            //{
            //
            //}

            for (int i = 1; i <= 5; i++)   //programm võtab i väärtuse...
            {
                Console.WriteLine(i);    //...ja prindib selle ekraanile
            }                               //siis läheb programmi algusesse tagasi lisades i'le +1
        }

        private static void Hinne3_I()
        {
            //if (true)
            //{
            //
            //}
            if (200 < 300)      //kui 200 on väiksem kui 300
            {
                Console.WriteLine("200 on väiksem kui 300.");    //kirjutatakse ekraanile "200 on väiksem kui 300."
            }
        }
    }
}
