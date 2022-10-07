using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund9_2
{
    internal class laps:inimene,IViisakas
    {
        public laps(int vanus) : base(vanus)
        {

        }

        public void koputauksele(string korda)
        {
            for (int i = 0; i < korda.Length; i++)
            {
                Console.WriteLine("kopp");
            }

        }
    }
}
