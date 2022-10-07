using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund9
{
    internal class laud
    {
        private int _jalg;
        private int _teinekülg;
        private string _materjal;
        protected int _pikkus;
        protected int _laius;

        public laud(int jalg, int teinekülg, string materjal)
        {
            _jalg = jalg;
            _teinekülg = teinekülg;
            _materjal = materjal;
        }
        public void Pindala(int jalg, int teinekülg, bool onMetallik = false)
        {
            _jalg = jalg;
            _teinekülg = teinekülg;
            var pindala = jalg * teinekülg;
        }
        public void JalgadePikkus(int jalg)
        {
            _jalg = jalg;
        }

        private int _jalgu;
        protected int _pikkus;
        private string _materjal;
        protected int _laius;
        private int _kõrgus;
        private string _vastupidavus;

        public laud(int jalgu, int pikkus, int laius, int kõrgus, string vastupidavus, string materjal = "puit")
        {
            _jalgu = jalgu;
            _pikkus = pikkus;
            _materjal = materjal;
            _laius = laius;
            _kõrgus = kõrgus;
            _vastupidavus = vastupidavus;
        }
        public int leiapindala()
        {
            return _pikkus * _laius;
        }
        public int leiajalgadepikkus()
        {
            return (_jalgu * _kõrgus);
        }
        public void Andmed()
        {
            Console.WriteLine($"-------LAUD--------");
            Console.WriteLine($"Materjal: {_materjal}");
            Console.WriteLine($"Vastupidavus: {_vastupidavus}");
            Console.WriteLine($"Pikkus: {_pikkus}");
            Console.WriteLine($"Laius: {_laius}");
            Console.WriteLine($"Kõrgus: {_kõrgus}");
            Console.WriteLine($"Jalgu: {_jalgu}");
            Console.WriteLine($"Kogupikkus {leiajalgadepikkus()}");
        }
    }
    internal class reha
    {
        private int _varrepikkus;
        private int _vahed;
        private string _varrematerjal;
        private string _rehamaterjal;

        public reha(int varrepikkus, int vahed, string varrematerjal, string rehamaterjal)
        {
            _varrepikkus = varrepikkus;
            _vahed = vahed;
            _varrematerjal = varrematerjal;
            _rehamaterjal = rehamaterjal;
        }
        public void VahetaVars(string materjal, int pikkus)
        {
            _varrematerjal = materjal;
            _varrepikkus = pikkus;
        }
        public void Vahetaots(string materjal, int varrematerjal)
        {
            _rehamaterjal = materjal;
            //_varrematerjal = varrematerjal;
        }
        public void SaeVarsLühemaks(int pikkus)
        {
            if (pikkus > _varrepikkus)
            {
                throw new ArgumentOutOfRangeException("vart ei saa rohkem lõigata");
            }
            else
            {
                _varrepikkus -= pikkus;
            }
        }
        public bool RehaOnSobiv(int inimesepikkus)
        {
            return inimesepikkus * 80 / 100 > _varrepikkus;
        }

    }
}
