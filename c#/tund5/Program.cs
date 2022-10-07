using System;
using System.IO;
namespace tund5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Environment.SpecialFolder.DesktopDirectory
            FileStream f = new FileStream("inimesed.txt", FileMode.Create,FileAccess.ReadWrite);
            StreamWriter writer= new StreamWriter(f);
            string nimi=string.Empty;
            do
            {
                Console.Write("Sisesta nimi:");
                nimi=(Console.ReadLine());
                if(nimi!="")
                {
                    writer.WriteLine(nimi);
                }
            } while (nimi != "");
            writer.WriteLine("Juku");
            writer.WriteLine("Kati");
            writer.Close();

            FileStream fr = new FileStream("inimesed.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(fr);
            string rida =reader.ReadLine();
            while (rida !=null)
            {
                Console.WriteLine(rida);
                rida = reader.ReadLine();
            }
            var nimed = File.ReadAllLines("inimesed.txt");
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {nimed[i]}");
            }

            //------------------------------------------------------------//

            //*Tekita programmi abil fail, milles oleksid arvud ja nende ruudud ühest kahekümneni

            FileStream fa = new FileStream("ülesandefail.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter writer2 = new StreamWriter(fa);
            string nimi2 = string.Empty;

            ////var path=Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            ////var ruududfailinimi = "ruudud.txt";
            ////FileStream f= new FileStream(Path.Combine(path,ruududfailinimi))
                for (int i = 0; i < 20; i++)
                {
                    writer2.WriteLine($"{i+1} - {(i+1)*(i+1)}");
                }
            writer2.Close();

            //*Tekstifaili igal real on müüdud kauba hind. Arvuta programmi abil nende hindade summa.

            int a = 0;
            FileStream fb = new FileStream("kaubad.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter writer3 = new StreamWriter(fb);
            nimi2 = (Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                //*Iga hinna kõrval on ka selle hinnaga müüdud kauba kogus.
                //Korruta igal real hind kogusega ning liida lõpuks summad kokku.

                ////var hinnadjakogused = File.ReadAllLines(ruududfailinimi);
                ////var summa =0;
                ////foreach (var rida in hinnadjakogused)
                ////{
                //    //var hind_kogus = rida.Split();
                //    //var hind = int.Parse(hind_kogus[0]);
                //    //var kogus = int.Parse(hind_kogus[1]);
                //    //summa += hind * kogus
                ////}
                ////Console.WriteLine("ijklj + summa);

                writer3.WriteLine($"{i + 1} eurot {i+1} tükki");
                a += (i+1)*(i+1);
            }
            writer3.WriteLine($"summa on {a}");
            writer3.Close();


            //*Võrreldes eelmise ülesandega kirjuta teise faili igale reale esimese faili
            //vastaval real oleva hinna ja koguse korrutis.

            FileStream fc = new FileStream("kaubad2.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter writer4 = new StreamWriter(fc);
            string nimi4 = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                writer4.WriteLine($"{i + 1} * {i+1} kaupa = {(i + 1) * (i + 1)} eurot");
            }
            writer4.Close();

            fc = new FileStream("kaubad2.txt", FileMode.Open, FileAccess.Read);
            StreamReader writer5 = new StreamReader(fc);
            string line = reader.ReadLine();
            int summa = 0;
            while (line != null)
            {
                summa += int.Parse(line);
                line = reader.ReadLine();
            }
            Console.WriteLine(summa);

            //--------------------------------------------------------//

            Random r = new Random();
            Console.WriteLine(r.NextDouble()); //Nullist üheni
            Console.WriteLine(r.Next(20)); //Täisarv alla 20
            Console.WriteLine(r.Next(50, 100)); //Viiekümnest sajani
            string[] nimed2 = { "Juku", "Kati", "Mati" };
            Console.WriteLine(nimed[r.Next(nimed.Length)]); //Juhuslik nimi

            //---------------------------------------------------//

            //*Trüki juhuslike teguritega korrutamisülesanne

            int esimene = (r.Next(20)); //Täisarv alla 20
            int teine = (r.Next(20));
            Console.WriteLine($"kui palju on {esimene} * {teine}?");
            int vastus1 =int.Parse (Console.ReadLine());
            //* Kontrolli, kas kasutaja pakutud vastus oli õige
            //* Sõltuvalt vastuse õigsusest lase arvutil pakkuda olemasolevate hulgast valitud
            //kiitev või julgustav kommentaar.
            if (esimene * teine == vastus1)
            {
                Console.WriteLine("õige");
                string[] nimed4 = { "tubli laps", "hästi tehtud"};
                Console.WriteLine(nimed4[r.Next(nimed4.Length)]);
            }
            else
            {
                Console.WriteLine("vale");
                string[] nimed3 = { "pole hullu", "järgmine kord läheb paremini"};
                Console.WriteLine(nimed3[r.Next(nimed3.Length)]);
            }
        }
    }
}
