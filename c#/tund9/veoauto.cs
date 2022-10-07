using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund9
{
    internal class veoauto : auto
    {
        protected uint _koormamass;
        protected uint _kandevõime;
        public veoauto(string mark, string värv,uint kandevõime, string keretüüp = "kastikas") : base(mark, värv, kandevõime, keretüüp)
        {
            _koormamass = 0;
            _kandevõime = kandevõime;
        }
        /// <summary>
        /// suurendab auto koormat väärtuse võrra
        /// </summary>
        /// <param name="koormamass">lisatud koorma mass</param>
        /// <exception cref="ArgumentOutOfRangeException">kui koorem on suurem</exception>
        public void laekoorem(uint koormamass)
        {
            var vabamass = _kandevõime - _koormamass;
            if (koormamass > vabamass)
            {
                throw new ArgumentOutOfRangeException(nameof(koormamass), "koorem ületab kandevõime");
            }
            else
            {
                _koormamass += koormamass;
            }
        }
        public override string ToString()
        {
             return base.ToString()+$"\nKandevõime on {_kandevõime}\nKoormamass {_koormamass}";
        }
        public override void Tuunimootorit()
        {
            Console.WriteLine("ei näpi mootorit");
        }
    }
}
