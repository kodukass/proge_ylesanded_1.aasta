using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund9
{
    internal class Daam:Inimene
    {
        public Daam(int vanus):base(vanus)
        {
        }
        public override void YtleVanus()
        {
            Console.WriteLine($"Minu vanus on {_vanus}");
        }
    }
}
