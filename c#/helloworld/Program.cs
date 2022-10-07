using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esimene arv");
            string nimi=Console.ReadLine();
            int arv1=int.Parse(nimi);
            Console.WriteLine("teine arv");
            string nimi1=Console.ReadLine();
            int arv2=int.Parse(nimi1);
            // Console.WriteLine("kui vana sa oled");
            // int vanus= int.Parse(Console.ReadLine());
            // Console.WriteLine("esimene sõna");
            // Console.WriteLine("teine\n sõna");
            Console.WriteLine($"arvude {arv1} ja {arv2} korrutis on {arv1*arv2}");
            Console.WriteLine("esimene nimi");
            string nimi11=Console.ReadLine();
            Console.WriteLine("teine nimi");
            string nimi22=Console.ReadLine();
            Console.WriteLine($"{nimi11} ja {nimi22} on pinginaabrid")
        }
    }
}
