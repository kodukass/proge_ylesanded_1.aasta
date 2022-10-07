using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summeerija
{
    class salvestavsummeerija: Isummeerija
    {
        private int[] _arvud;
        private int _kogus;
        public void Alusta()
        {
            _arvud = new int[10];
            _kogus = 0;
        }

        public int Kysisumma()
        {
            if (_arvud == null)
            {
                return 0;
            }
            int summa = 0;
            foreach (var arv in _arvud)
            {
                summa += arv;
            }
            return summa;
        }

        public void Lisa(int lisatavkogus)
        {
            if (_arvud == null)
            {
                Alusta();
            }
            if (_kogus == _arvud.Length)
            {
                var uus = new int[_kogus * 2];
                Array.Copy(_arvud, uus, _kogus);
            }
            _arvud[_kogus++]= lisatavkogus;
        }
    }

}
