using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund6._1
{
    internal class Riidelapp
    {
        private int _pikkus;
        private int _laius;

        public int Annapindala()
        {
            return _pikkus*_laius;
        }

        private string _toon;

        public Riidelapp(int x, int y, string z)
        {
            _pikkus = x;
            _laius = y;
            _toon = z;
        }

        public Riidelapp PoolitaUuega()
        {
            Poolita();
            return new Riidelapp(_pikkus,_laius, _toon);
        }

        public Riidelapp Poolita1(int allesjäävprotsent)
        {
            if (_pikkus>_laius)
            {
                var jääkpikkus = (100 - allesjäävprotsent) * _pikkus / 100;
                _pikkus -= jääkpikkus;
                return new Riidelapp(jääkpikkus, _laius, _toon);
            }
            else
            {
                var jääklaius = (100 - allesjäävprotsent) * _pikkus / 100;
                _laius -= jääklaius;
                return new Riidelapp(_pikkus, jääklaius, _toon);
            }
        }

        public int GetX() { return _pikkus; }
        public int GetY() { return _laius; }
        public string GetZ() { return _toon; }
        public void Kuvaandmed()
        {
            System.Console.WriteLine("__________Riidelapi andmed________-");
            System.Console.WriteLine($"Pikkus:\t{_toon}mm");
            System.Console.WriteLine($"Laius:\t{_laius}mm");
            System.Console.WriteLine($"Pindala:\t{Annapindala()/1000000.0} m2");
            System.Console.WriteLine($"Toon:\t{_toon}");
        }
        public void Poolita()
        {
            if (_pikkus>_laius)
            {
                System.Console.WriteLine($" pikkus: {GetX()} mm, laius: {GetY() / 2} mm");
            }
            else
            {
                System.Console.WriteLine($" pikkus: {GetX()/2} mm, laius: {GetY()} mm");
            }
        }
    }
}
