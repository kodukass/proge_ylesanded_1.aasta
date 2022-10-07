using System;

namespace tund6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lapp1 = new Riidelapp(1500, 2000, "roosa");
            lapp1.Kuvaandmed();
            int pindala = lapp1.Annapindala();
            lapp1.Poolita();
            lapp1.Kuvaandmed(); //laius 1000
            lapp1.Poolita();
            lapp1.Kuvaandmed(); //pikkus 750
            Riidelapp lapp2 = lapp1.PoolitaUuega();
            Console.WriteLine("uuega poolitamine");
            lapp1.Kuvaandmed();
            lapp2.Kuvaandmed();
            Riidelapp lapp3 = lapp1.Poolita1();
        }
    }
}
