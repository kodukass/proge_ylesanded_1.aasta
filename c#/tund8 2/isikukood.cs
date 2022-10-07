using System;

namespace tund8_2
{
    internal class isikukood
    {
        private string _ik;

        public isikukood(string isikukood)
        {
            if (isikukood.Length!=11)
            {
                throw new ArgumentOutOfRangeException("pole isikukood");
            }
            _ik = isikukood;

            try
            {
                Annasünnipäev();
            }
            catch(ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException("pole kuupäeva");
            }
        }
        public int Annapäev() { return int.Parse(_ik.Substring(5, 2)); }
        public int Annakuu() { return int.Parse(_ik.Substring(3, 2)); }
        public string Annakuunimi() 
        { 
            string[] kuud = { "", "jaanuar", "veebruar", "märts", "aprill", "mai", "juuni", "juuli", "august", "september", "oktoober", "november", "detsember" };
            return kuud[Annakuu()];
        }
        public int Annaaasta()
        {
            var sajandinumber = int.Parse(_ik.Substring(0, 1));
            var aasta = 0;
            if (sajandinumber <3)
            {
                aasta = 1800;
            }
            else if (sajandinumber <5)
            {
                aasta = 1900;
            }
            else if (sajandinumber <7)
            {
                aasta = 2000;
            }
            else
            {
                aasta = 2100;
            }
            aasta+=int.Parse(_ik.Substring(1, 2));
            return aasta;
        }
        public DateTime Annasünnipäev() { return new DateTime(Annaaasta(), Annakuu(), Annapäev()); }

        //          * Kontrolli isikukoodi objekti tegemisel koodi pikkust

        //          * Kontrolli isikukoodi kontrollisumma õigsust vastavalt järgnevale algoritmile:

        //          Isikukoodi kontrolli algoritm:
        //          >Isikukoodis peavad kõik sugu ning kuupäeva tähistavad väärtused olema võimalikud ning viimane kontrollnumber arvutatakse järgneva algoritmi järgi:

        //          >>liidetakse kokku esimese üheksa numbri korrutised igale arvule vastava järjekorranumbriga,(kümnenda numbri puhul ühega ning leitakse saadud summa jääk jagamisel 11-ga.)
        //          >>Kui jääk on võrdne kümnega, siis tehakse arvutus uuesti ning võetakse teguriteks vastavalt 3, 4, 5, 6, 7, 8, 9, 1, 2, 3.
        //          Näide: isikukoodi 37605030299 kontroll.
        //          Summa = 1*3 + 2*7 + 3*6 + 4*0 + 5*5 + 6*0 + 7*3 + 8*0 + 9*2 + 1*9 = 108
        //          108 jääk jagamisel 11-ga on 9 => isikukoodi viimane number peab olema üheksa.
        public int ArvutaViimaneNumber() 
        {
            var summa = 0;
            var number = 0;
            isikukood[]numbrid=new isikukood[_ik.Length];
            for (int i = 0; i < numbrid.Length; i++)
            {
                Console.WriteLine((numbrid[i]));
                //int.Parse(_ik.Substring(i, 1));
                //summa += numbrid[i];                
            }
            return summa / 11;
            if (summa == 10)
            {

            }
            return summa;
        }
    }
}