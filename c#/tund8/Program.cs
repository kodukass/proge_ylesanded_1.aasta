using System;

namespace tund8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            riidelapp rl = new riidelapp(1500, 1600, "roosa");
            riidelapp[]riidelappid = new riidelapp[50];
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                riidelappid[i] = new riidelapp(random.Next(50), random.Next(150), riidelapp.toonid[random.Next(riidelapp.toonid.Length)]);
                riidelappid[i].andmed();
            }
            riidelapp[]kaltsukott=new riidelapp[riidelappid.Length];
            for (int i = 0;i< kaltsukott.Length;i++)
            {
                if (riidelappid[i].kalts())
                {
                    kaltsukott[i] = riidelappid[i];
                }
                else
                {
                    kaltsukott[i] = new riidelapp(5, 5, "kollane");
                }
                kaltsukott[i].andmed();
            }
            int riidelappidepindaladesumma = pindaladesumma(riidelappid);
            int kaltsukotipindaladesumma = pindaladesumma(kaltsukott);
            int keskminepindala = riidelapp.arvutakeskminepindala();
            Console.WriteLine("riidelappi pindala"+riidelappidepindaladesumma);
            Console.WriteLine("kaltsukoti pindala" + kaltsukotipindaladesumma);
            Console.WriteLine("kokku pindala"+(riidelappidepindaladesumma+kaltsukotipindaladesumma)/(riidelappid.Length+kaltsukott.Length));
            Console.WriteLine("keskmine"+keskminepindala);
        }

        private static int pindaladesumma(riidelapp[] riidelappid)
        {
            var summa = 0;
            foreach (var lapp in riidelappid)
            {
                summa += lapp.AnnaPindala();
            }
            return summa;
        }
    }
}
