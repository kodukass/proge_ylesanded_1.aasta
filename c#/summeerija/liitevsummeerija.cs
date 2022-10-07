using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summeerija
{
    internal class liitevsummeerija:Isummeerija
    {
        private int _summa;
        public void Alusta()
        {
            _summa = 0;
        }
        public int Kysisumma()
        {
            return _summa;
        }

        public void Lisa(int kogus)
        {
            _summa += kogus;
        }
        
    }
}
