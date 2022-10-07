using System;

namespace tund4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summa = Class1.Liida(5, 6);
            int korrutis = Class1.Korruta(5, 6);
            Console.WriteLine(summa);
            Console.WriteLine(korrutis);
            //*Lisa käsklus täisarvude astendamiseks tsükli abil.Katseta
            //int astendus=Class1.Astenda(5,6);
            //*Lisa kolmas fail paari tärnidest kujundeid joonistava funktsiooniga.Katseta peaprogrammis mõlema abifaili funktsioonide väljakutseid.
            Joonistaja.TeeRuut();
            Joonistaja.TeeJoon();
            //"Juku".AsMemory();


            string s = "Juku tuli kooli";
            Console.WriteLine("Pikkus: " + s.Length);
            Console.WriteLine(s.Substring(5, 4));
            Console.WriteLine("'tuli' kohal " + s.IndexOf("tuli"));
            string s2 = s.Insert(9, " vara");
            Console.WriteLine(s2);
            string s3 = s.Remove(5, 5); //Kuuendast alates viis tähte
            Console.WriteLine(s3);
            if (s.StartsWith("Juku"))
            {
                Console.WriteLine("Algab Jukuga");
            }
            if (s.IndexOf("kala") == -1)
            {
                Console.WriteLine("Siin ei ole kala");
            }
            Console.WriteLine(s.Replace("tuli", "jooksis"));


            string sl = "Tallinn,Tartu,Narva";
            string[] linnad = sl.Split(new char[] { ',' });
            foreach (string linn in linnad)
            {
                Console.WriteLine(linn);
            }
            Console.WriteLine(String.Join("; ", linnad));

            string nimedSõne = "Miia Mall Mell";
            string[] nimed = nimedSõne.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var nimi in nimed)
            {
                Console.WriteLine(nimi);
            }
            Console.WriteLine(string.Join(" ja ",nimed));

            //--------------------------------------------------------//

            //*Trüki inimese nime eelviimane täht

            string sll = "Kristin";
            string s3l = sll.Remove(0, 5);
            string s3ll = s3l.Remove(1, 1);
            Console.WriteLine(s3ll);

            //*Teata, kas sisestatud nimi algab A - ga

            if (sll.StartsWith("A"))
            {
                Console.WriteLine("Algab A-ga");
            }
            else
            {
                Console.WriteLine("ei alga");
            }

            //*Trüki sisestatud nimi välja suurtähtedega

            string s33 = sll.ToUpper();
            Console.WriteLine(s33);

            //*Teata, kas lauses leidub sõna "ja"

            string lause1 = "Jaanalinnu maja vajab remonti ja värvimist";
            if (lause1.IndexOf("ja") == -1)
            {
                Console.WriteLine("Siin ei ole ja'd");
                
            }
            else
            {
                Console.WriteLine("on ja");
                //*Asenda olemasolu korral "ja" sõnaga "ning" ja teata asendusest
                Console.WriteLine("vahetan ja ning'iga");
                string lause2 = lause1.Insert(11, " ning");
                string lause3 = lause2.Remove(17, 3);
                Console.WriteLine(lause3);
            }

            //*Trüki välja lause kõige pikem sõna

            Console.WriteLine(lause1.Substring(15, 5));
        }
    }
}
