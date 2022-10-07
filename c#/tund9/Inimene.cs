using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund9
{
    class Inimene
    {
        protected int _vanus;
        protected int _pikkus;
        
        public Inimene(int vanus, int pikkus)
        {
            _vanus = vanus;
            _pikkus = pikkus;
        }
        public Inimene(int vanus):this(vanus,-1)
        {
            
        }
        public void YtleVanus()
        {
            Console.WriteLine("Minu vanus on " + _vanus + " aastat");
        }
        public int AnnaPikkus() { return _pikkus; }
    }
}
