using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund8
{
    internal class riidelapp
    {
        private int _pikkus;
        private int _laius;
        private string _toon;
        private int _kaltsupikkus;
        private int _kaltsulaius;
        public static string[] toonid = { "sinine", "must", "valge" };
        private static int _koguPindala = 0;
        private static int _kogus = 0;
        private static readonly int kaltsupiir = 10;
        public riidelapp(int pikkus, int laius, string toon)
        {
            _pikkus = pikkus;
            _laius = laius;
            _toon = toon;
            _kogus++;
            _koguPindala += AnnaPindala();
        }
        public int GetX() { return _pikkus; }
        public int GetY() { return _laius; }
        public string GetZ() { return _toon; }

        public int Pindala(int pikkus, int laius)
        {
            _pikkus = pikkus;
            _laius = laius;
            return pikkus * laius;
        }
        public void andmed()
        {
            System.Console.WriteLine("__________Riidelapi andmed________-");
            System.Console.WriteLine($"Pikkus:\t{_toon}mm");
            System.Console.WriteLine($"Laius:\t{_laius}mm");
            System.Console.WriteLine($"Pindala:\t{AnnaPindala()} m2");
            System.Console.WriteLine($"Toon:\t{_toon}");
        }

        public static int arvutakeskminepindala()
        {
            if (_kogus==0)
            {
                return -1;
            }
            else
            {
                return _koguPindala/_kogus;
            }
            
        }

        internal int AnnaPindala()
        {
            return _pikkus * _laius;
        }

        public bool kalts()
        {
            return _pikkus < kaltsupiir || _laius < kaltsupiir;
        }
    }
}
