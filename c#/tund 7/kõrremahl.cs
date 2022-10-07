using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund_7
{
    internal class kõrremahl
    {
        private string _maitse;
        private double _kangus;
        private string _värv;
        //private ConsoleColor _color;
        private string _tootja;
        private double _kogus;

        public kõrremahl(string maitse, string värv, string tootja, double kogus, double kangus =100)
        {
            _maitse = maitse;
            _värv = värv;
            _tootja = tootja;
            _kogus = kogus;
            _kangus = 100;
        }
        public void LahjendaVeega(double veekogus)
        {
            if (_kogus >0)
            {
                _kogus += veekogus;
                _kangus -= veekogus*100/_kogus;
            }
        }
        /// <summary>
        /// teeb olemasoleva kõrremahla kaheks
        /// </summary>
        /// <returns>teise poole pakist</returns>
        public kõrremahl PakendaÜmber(double kogus)
        {
            kogus /= 2;
            return new kõrremahl(_maitse,_värv,_tootja,_kogus,_kangus);
        }
        public int MitmeleInimesele()
        {
            const double inimesepiir = 1;
            return (int) Math.Ceiling(_kogus / inimesepiir);
        }
        public void KuvaAndmed()
        {
            Console.WriteLine($"Maitse: {_maitse}");
            Console.WriteLine($"Kangus: {_kangus}%");
            Console.WriteLine($"Kogus: {_kogus}liitrit");
            Console.WriteLine($"Selle suudab ära juua {MitmeleInimesele()} inimest");
        }
    }
}
