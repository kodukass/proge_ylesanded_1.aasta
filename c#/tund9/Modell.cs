using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund9
{
    class Modell : Inimene
    {
        protected int _ümbermõõt;
        public Modell(int vanus, int ümbermõõt, int pikkus = -1) : base(vanus, pikkus)
        {
            _ümbermõõt = ümbermõõt;
        }
        public void Esitle()
        {
            YtleVanus();
            Console.WriteLine($"Minu ümbermõõt on {_ümbermõõt}cm.");
            if (_pikkus==-1)
            {
                Console.WriteLine("Pikkus puudub");
            }
            Console.WriteLine($"Minu pikkus on {_pikkus}");
        }
    }
}
