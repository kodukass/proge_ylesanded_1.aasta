using System;

namespace suhtlusarvutiga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int arv2=int.Parse(nimi1);
            Console.WriteLine($"arvude {arv1} ja {arv2} korrutis on {arv1*arv2}");
            // Küsi kahe inimese nimed ning teata, et täna on nad pinginaabrid
            Console.WriteLine("esimene nimi");
            string nimi11=Console.ReadLine();
            Console.WriteLine("teine nimi");
            string nimi22=Console.ReadLine();
            Console.WriteLine($"{nimi11} ja {nimi22} on pinginaabrid");
            // Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala
            Console.WriteLine("esimene seina laius");
            string laius1=Console.ReadLine();
            int number1=int.Parse(laius1);
            Console.WriteLine("teine seina laius");
            string laius2=Console.ReadLine();
            int number2=int.Parse(laius2);
            Console.WriteLine($"põranda pindala on{number1*number2}");
            // Leia 30 % hinnasoodustusega hinna põhjal alghind
            Console.WriteLine("soodushind");
            string soodushind=Console.ReadLine();
            int number=int.Parse(soodushind);
            Console.WriteLine($"hind on {number/0.3}");

        }
    }
}
