using System;
using System.Linq;
using System.Collections.Generic;

namespace kontrolltöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P1_tuttavad();
            //P2_Arvud();
            //P3_Vanused();
            //P4_Pikkused();
            P5_Sugu();
        }
        private static void P1_tuttavad()
        {
            string[] nimed = new string[3];
            nimed[0] = "Mia";
            nimed[1] = "Tiina";
            nimed[2] = "Mari";
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine($"Kas sa tead {nimed[i]}?");
                string kasnimi = Console.ReadLine();
                if (kasnimi == "ei")
                {
                    Console.WriteLine("Lisa nimi:");
                    string lisanimi = Console.ReadLine();
                    nimed[i] = lisanimi;
                }

            }
            Console.WriteLine(nimed[0]);
            Console.WriteLine(nimed[1]);
            Console.WriteLine(nimed[2]);
        }
        private static void P2_Arvud()
        {
            int number;
            int valesisestusi = -1;
            do
            {
                valesisestusi++;
                Console.WriteLine("Sisesta number vahemikus 5-10");
                number = int.Parse(Console.ReadLine());
            } while (number < 5 || number > 10);

            string[] teated = new string[number];
            teadatäidetega(teated, valesisestusi);
            foreach (var teade in teated)
            {
                Console.WriteLine(teade);
            }

        } private static void teadatäidetega(string[] teated, int valesisestusi)
        {
            string teade = ($"Sisestasid arvu {valesisestusi} korda.");
            Array.Fill(teated, teade);
        }
        private static void P3_Vanused()
        {
            string[] nimed = new string[5];
            int[] vanused = new int[nimed.Length];

            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine("nimi palun");
                nimed[i] = Console.ReadLine();
                Console.WriteLine("vanus palun");
                vanused[i] = int.Parse(Console.ReadLine());
            }

            (string vanimanimi, int vanimavanus) = leiavanim(nimed, vanused);
            Console.WriteLine($"Kõige vanem on {vanimanimi}, ta on {vanimavanus} aastane.");

        }
        private static (string vanimanimi, int vanimavanus) leiavanim(string[] nimed, int[] vanused)
        {
            var vanimnimi = "";
            var vanimavanus = 0;
            for (int i = 0; i < vanused.Length; i++)
            {
                if (vanused[i] > vanimavanus)
                {
                    vanimavanus = vanused[i];
                    vanimnimi = nimed[i];
                }
            }
            return (vanimnimi, vanimavanus);
        }
        private static void P4_Pikkused()
        {
            int[] pikkusepiirid = { 100, 125, 150, 175, 200 };
            int[] pikkused = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}. inimese pikkus.");
                pikkused[i] = int.Parse(Console.ReadLine());
            }
            int enamusülemindex = leiaenamuspikkus(pikkused, pikkusepiirid);


            if (enamusülemindex == 0)
            {
                Console.WriteLine($"Enamus pikkused on kuni{pikkusepiirid[enamusülemindex]}");
            }
            else if (enamusülemindex == -1)
            {
                Console.WriteLine($"Enamus pikkusi on üle {pikkusepiirid.Length - 1}");
            }
            else
            {
                Console.WriteLine($"Enamus pikkuseid jäid {pikkusepiirid[enamusülemindex - 1]}-{pikkusepiirid[enamusülemindex]}");
            }
        }
        private static int leiaenamuspikkus(int[] pikkused, int[] pikkusepiirid)

        {
            int[] kogused = new int[pikkusepiirid.Length];
            foreach (var pikkus in pikkused)
            {
                for (int i = 0; i < pikkusepiirid.Length; i++)
                {
                    if (pikkus <= pikkusepiirid[i])
                    {
                        kogused[i]++;
                        break;
                    }
                }
            }
            var enim = kogused.Max();
            var ülepiiri = pikkused.Length - kogused.Sum();
            if (ülepiiri > enim)
            {
                return -1;
            }
            return Array.IndexOf(kogused, enim);
        }
        private static void P5_Sugu()
        {
            List<int> mehed = new();
            List<int> naised = new();
            Console.WriteLine("Sisesta vanuseid. Lõpetamiseks vajuta enter.");
            string input;
            bool onmees = true;
            do
            {
                input = küsivanust(onmees ? mehed : naised, $"Sisesta {(onmees ? "mehe" : "naise")}vanus:");
                onmees = !onmees;

            } while (input != string.Empty);
            double mehedkeskmine = arvutakeskmine(mehed);
            double naisedkeskmine = arvutakeskmine(naised);
            if (mehedkeskmine>naisedkeskmine)
            {
                Console.WriteLine($"Keskmiselt on mehed vanemad {mehedkeskmine - naisedkeskmine} aastat.");
            }
            else if (naisedkeskmine>mehedkeskmine)
            {
                Console.WriteLine($"Keskmiselt on naised vanemad {naisedkeskmine - mehedkeskmine} aastat.");
            }
            else
            {
                Console.WriteLine($"Keskmine vanus on võrdne.");
            }
        }

        private static double arvutakeskmine(List<int> numbrid)
        {
            double summa = 0;
            foreach (var arv in numbrid)
            {
                summa += arv;
            }
            return summa/numbrid.Count;
            //return numbrid.Average();
        }

        private static string küsivanust(List<int> list, string küsimus)
        {
            string input;
            Console.Write(küsimus);
            input=Console.ReadLine();
            if(input != string.Empty)
            {
                list.Add(int.Parse(input));
            }
            return input;
        
        }
        
    }
}
