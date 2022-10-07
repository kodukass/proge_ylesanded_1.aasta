using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund9
{
    internal class kirjutuslaud : laud
    {
        private Sahtel[] _sahtlid;

        public kirjutuslaud(int pikkus, int laius, int kõrgus,int sahtleid, string vastupidavus, string materjal = "puit") : base(jalgu, pikkus, laius, kõrgus, vastupidavus, materjal)
        {
            _sahtlid = loosahtlid(sahtleid);

        }
        /// <summary>
        /// loob laua alla kõrvuti sahtlid
        /// sahtli kõrgus 1/6 laua kõrgusest
        /// esimene on lukustatav sahtel ja iga 10's valepõhjaga
        /// </summary>
        /// <param name="sahtleid">sahtli kõrgus</param>
        /// <returns>loodud sahtlitega massiiv</returns>

        private Sahtel[] loosahtlid(int sahtleid)
        {
            _sahtlid=new Sahtel[sahtleid];
            byte sahtlilaius = (byte) _laius / sahtleid;
            byte sahtlikõrgus = (byte) _kõrgus / 6;
            for (int i=0;i<sahtleid;i++)
            {
                _sahtlid[i] = new Sahtel((byte)_pikkus, sahtlilaius, sahtlikõrgus, i ==0);
            }
        }
        public override string ToString()
        {
            string result="\n";
            foreach (var sahtel in _sahtlid)
            {
                result += sahtel.ToString() + "\n";
            }
            return base.ToString()+ $"sahtel:{_pikkus}x{_kõrgus}x{_laius}; {_onlukustatav}lukustatav; {_onvalepõhi}.";
        }
    }
}
