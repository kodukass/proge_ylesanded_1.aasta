using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund9
{
    internal class Sõiduauto:auto
    {
        protected uint _reisijaid;
        public Sõiduauto(string mark, string värv, int istekohti, string keretüüp="luukpära"):base(mark,värv,istekohti,keretüüp)
        {
            _reisijaid = 0;
        }
        /// <summary>
        /// laseb autosse reisijad sisse
        /// </summary>
        /// <param name="reisijatearv">kui palju siseneb</param>
        /// <returns>kui palju ei mahtund</returns>
        public uint Sisene(uint reisijatearv)
        {
            var vabukohti = _istekohti - _reisijaid;
            if (reisijatearv>vabukohti)
            {
                _reisijaid = (uint)_istekohti;
                return (uint)(reisijatearv-vabukohti);
            }
            _reisijaid += reisijatearv;
            return 0;
        }
    }
}
