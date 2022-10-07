
using System;

namespace tund9
{
    internal class Program
    {
        static bool KasMahubAllveelaeva(Inimene isik)
        {
            if(isik == null) return false;

            return isik.AnnaPikkus() < 165||isik is Modell;
        }
        static void Main(string[] args)
        {
            var mersu = new Sõiduauto("mersu", "hõbe", 5, "sedaan");
            var jalamehi = mersu.Sisene(7);
            Console.WriteLine($"jalgsi läheb {jalamehi}.");
            jalamehi =mersu.Sisene(3);
            Console.WriteLine($"jalgsi läheb {jalamehi}.");

            var scania = new veoauto("scania", "sinine", 15000);
            scania.laekoorem(12000);

            Inimene inim1 = new Inimene(13);
            inim1.YtleVanus();
            Modell modell = new Modell(19,100,179);
            modell.Esitle();

            Inimene inimModell=new Modell(11,40);
            inimModell.YtleVanus();

            Inimene[] rahvas = new Inimene[100];
            for (int i = 0; i < rahvas.Length; i++)
            {
                if (i <5)
                {
                    rahvas[i] = new Modell(17, 65, 167 + i % 10);
                }
                else
                {
                    rahvas[i] = new Inimene(25, 164);
                }
                rahvas[i].YtleVanus();
                if (KasMahubAllveelaeva(rahvas[i]))
                {
                    Console.WriteLine("jah");
                }
            }
            Inimene inimene =new Inimene(35);
            Daam daam = new Daam(35);
            inimene.YtleVanus();
            daam.YtleVanus();

            Inimene inimDaam = new Daam(35);
            inimDaam.YtleVanus();

            var kirjutuslaud = new kirjutuslaud(60, 170, 60, 5);
            Console.WriteLine(kirjutuslaud);
            var kirjutuslaud2 = new kirjutuslaud(60, 170, 60, 7);
            Console.WriteLine(kirjutuslaud2);
        }
    }
}
