using System;
class Korrutustabel
{
    //    public static void Main(string[] argumendid)
    //    {
    //        int ridadearv = 10, veergudearv = 10;
    //        if (argumendid.Length == 2)
    //        {
    //            ridadearv = int.Parse(argumendid[0]);
    //            veergudearv = int.Parse(argumendid[1]);
    //        }
    //        for (int rida = 1; rida <= ridadearv; rida++)
    //        {
    //            for (int veerg = 1; veerg <= veergudearv; veerg++)
    //            {
    //                Console.Write("{0, 5}", rida * veerg); //5 kohta
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}
    //using System;
    //class Alamprogramm
    //{
    //public static int Korruta(int arv1, int arv2)
    //{
    //    return arv1 * arv2;
    //}
    //public static int Liida(int arv1, int arv2)
    //{
    //    return arv1 += arv2;
    //}
    //public static int Lahuta(int arv1, int arv2)
    //{
    //    return arv1 -= arv2;
    //}
    //public static double Jaga(int hg, int jh)
    //{
    //    return (double)hg * 1.0 / jh;                   //!!!!!//
    //}
    //public static void Main(string[] arg)
    //{
    //    int arv1 = 4;
    //    int arv2 = 6;
    //    Console.WriteLine($"{arv1} korda {arv2} on {Korruta(arv1, arv2)}");
    //    Console.WriteLine(Korruta(3, 5));
    //double tulemus = Jaga(arv1, arv2);
    //    Console.WriteLine($"{arv1} pluss {arv2} on {Liida(arv1, arv2)}");
    //    Console.WriteLine($"{arv1} miinus {arv2} on {Lahuta(arv1, arv2)}");
    //Console.WriteLine($"{arv1} jagada {arv2} on {tulemus}");
    //------------------------------------------------------------//

    //private static Random random = new Random();
    //Console.WriteLine(new String('*',random.Next(20)));

    //----------------------------------------------------------//

    // Koosta alamprogramm kahe arvu keskmise leidmiseks
    {

            public static int Keskmine(int arv3, int arv4)
    {
        return (arv3 += arv4) / 2;
    }
    public static void Main(string[] arg)
    {
        int arv3 = 4;
        int arv4 = 6;
        Console.WriteLine($"{arv3} ja {arv4} keskmine on {Keskmine(arv3, arv4)}");
    }

    //-----------------------------------------------------------//

    // Koosta alamprogramm etteantud arvu tärnide väljatrükiks.Katseta.

    public static void Main(string[] argumendid)
    {
        int arv1 = 10;
        for (int i = 0; i < arv1; i++)
        {
            Console.WriteLine($"*");
        }
    }
}

//-------------------------------------------------------------//

Küsi inimeselt kolm arvu.Iga arvu puhul joonista vastav kogus tärne ekraanile
        public static int TrykiTärnid(int arv, string asi)
    {
        for (int i = 0; i < arv; i++)
        {
            Console.Write($"asi");
        }
        Console.WriteLine();
    }
    public static void Main(string argumendid)
    {
        Console.WriteLine("1 arv");
        int arv1 = int.Parse(Console.ReadLine());
        Console.WriteLine("2 arv");
        int arv2 = int.Parse(Console.ReadLine());
        Console.WriteLine("3 arv");
        int arv3 = int.Parse(Console.ReadLine());

        Console.WriteLine($"{TrykiTärnid(arv1, "*")}");

    }
}
//--------------------------------------------------------//

//Koosta programm, mis kutsub seda funktsiooni välja 30 korda juhuslike positiivsete täisarvudega,
//mis on väiksemad kui 20.

public static int TrykiTärnid(int arv, string asi)
    {
        for (int i = 0; i < arv; i++)
        {
            Console.Write($"asi");
        }
        Console.WriteLine();
    }
    public static void Main(string argumendid)

        private static Random random = new Random()
        {
        Console.WriteLine(new String('*',random.Next(20)));
}

for (int i = 0; i <= 30; i++)
{
    Console.WriteLine($"{random}");
}

    }


    //--------------------------------------------------------//

    //Iga rea ette kirjutatakse arv, mitu sümbolit on reas.
    //3 * * *

    public static int TrykiTärnid(int arv, string asi)
    {
        for (int i = 0; i < arv; i++)
        {
            Console.Write($"asi");
        }
        Console.WriteLine();
    }
    public static void Main(string argumendid)


    private static Random random = new Random()
    {
    Console.WriteLine(new String('*',random.Next(20)));
}

for (int i = 0; i <= 30; i++)
{
    Console.WriteLine($"{random}");
}

//---------------------------------------------------------//

//Funktsiooni kutsutakse välja mitte 30 korda, vaid juhuslik arv kordi vahemikus 20 kuni 40.

//----------------------------------------------------------//

//Funktsioon saab ette ühe argumendi asemel kaks argumenti: lisaks arvule ka sümboli, mida trükitakse.

//TrykiTärnid(4,"@")

//4 @ @ @ @