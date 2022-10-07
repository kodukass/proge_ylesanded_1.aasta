using System;

namespace tund_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mersu = new auto("Mercedes-Benz", "Hõbe", 5, "sedaan");
            Console.WriteLine($"Mersu värv: {mersu.AnnaVärvus()}");
            mersu.MuudaVärv("Hõbe", true);
            Console.WriteLine($"Mersu uus värv: {mersu.AnnaVärvus()}");
            mersu.MuudaVelge(19);
            mersu.MuudaKohta(1);
            mersu.Andmed();
            mersu.TuuniMootorit();
            mersu.MuudaVelge(-5);
            mersu.MuudaKohta(-5);
            mersu.TäiustaSisustust();
            for (int i = 0; i < 5; i++)
            {
                if (mersu.TäiustaSisustust())
                {
                    Console.WriteLine("Täiustamine õnnestus. Uued andmed:");
                    mersu.Andmed();
                }
                Console.WriteLine("Enam paremaks minna ei saa.");
            }

            //var draakon = new kõrremahl("laim", "sinine", "Põltsamaa", 1);
            //draakon.LahjendaVeega(0.5);

            //var laud1 = new laud(4, 5, 4, 5, "tugev", "puit");
            //laud1.Andmed();

            //var masin = new nõudemasin(20);
            //while (masin.täida(3)==0)
            //{
            //    masin.lisapesutablet();
            //    masin.pesenõud();
            //}

            var reha = new reha("puit", 10, 130);
            if (reha.RehaOnSobiv(180))
            {
                Console.WriteLine("paras");
            }
            else
            {
                Console.WriteLine("ei ole paras")
            }
            Console.WriteLine($"pulki vaja : {reha.ArvutaPulkadeArv(1, 3, 10)}");
        }
    }
}
