using System;

namespace summeerija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var liitevSummeerija = new liitevsummeerija();
            liitevSummeerija.Lisa(7);

            Console.WriteLine(liitevSummeerija.Kysisumma());
            var salvestatavSummeerija=new salvestavsummeerija();
            salvestatavSummeerija.Lisa(7);
            salvestatavSummeerija.Alusta();
            Console.WriteLine(salvestatavSummeerija.Kysisumma());

            Isummeerija testsummeeria = summeerijavabrik.loosummeerija(10);
            Console.WriteLine(testsummeeria);
        }
    }
}
