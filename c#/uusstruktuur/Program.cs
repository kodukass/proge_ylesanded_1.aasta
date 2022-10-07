using System;

namespace uusstruktuur
{
    struct Andmed
    {
        public int x;
        public int y;
        public string z;
    }
    //struct Punkt
    //{
    //    public int x;
    //    public int y;
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //a-1,2,b-3,4,5
            //    Punkt a;
            //    a.x = 1;
            //    a.y = 2;
            //    Punkt b;
            //    b.x = 3;
            //    b.y = 4;
            //    Punkt c;
            //    c.x = 5;
            //    c.y = 6;
            //    int[] xid = { 1, 3, 4 };
            //    int[] yid = { 2, 4, 5 };
            //    Punkt[] punktid = new Punkt[3] { a, b, c };
            //    Console.WriteLine(a.x + " " + punktid[0].x);
            //    a.x = 11;
            //    Console.WriteLine(a.x + " " + punktid[0].x);
            //}

            //----------------------------------------//

            //*Koosta struktuur riidelappide andmete hoidmiseks: pikkus, laius, toon
            //* Katseta loodud andmetüüpi paari eksemplariga.
            ////Andmed p;
            ////p.x = 12;
            ////p.y = 13;
            ////p.z = "roosa";
            ////Andmed l;
            ////l.x = 14;
            ////l.y = 15;
            ////l.z = "sinine";
            ////Andmed t;
            ////t.x = 16;
            ////t.y = 17;
            ////t.z = "punane";
            ////Andmed[] andmed = new Andmed[3] { p, l, t };
            ////Console.WriteLine(p.x + " " + andmed[0].y+" "+ andmed[0].z);
            ////Console.WriteLine(l.x + " " + andmed[1].y + " " + andmed[1].z);
            ////Console.WriteLine(t.x + " " + andmed[2].y + " " + andmed[2].z);

            //*Loo lappidest väike massiiv, algväärtusta juhuarvude abil.
            //* Trüki välja lappide andmed, mille mõlemad küljepikkused on vähemalt 10 cm.
            Random r = new Random();
            
            Riidelapp riidelapp1;
            riidelapp1.p = 10;
            riidelapp1.l = 20;
            riidelapp1.t = "roosa";
            Console.WriteLine($"Pikkus: {riidelapp1.p}\nlaius: {riidelapp1.l}\ntoon: {riidelapp1.t}");
            Riidelapp[] riidelapid = new Riidelapp[100];
            for (int i = 0; i < riidelapid.Length; i++)
            {
                riidelapid[i].p=r.Next(1,50);
                riidelapid[i].l = r.Next(1, 50);
                riidelapid[i].t = toonid[r.Next(toonid.Length)];
                if (riidelapid[i].p>=10 && riidelapid[i].l>=10)
                {
                    Console.WriteLine($"Pikkus: {riidelapp1.p}\nlaius: {riidelapp1.l}\ntoon: {riidelapp1.t}");
                }
            }
        }
    }
}
