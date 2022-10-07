using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund_7
{
    internal class auto
    {
        private static Random _random = new Random();
        private string _värv;
        private string _mark;
        private int _istekohti;
        private string _keretüüp;
        private double _kiirendus;
        private int _tippkiirus;
        private bool _metallikVärv;
        private string _istmeMaterjal;
        private int _veljeDiameeter;
        public auto(string mark, string värv, int istekohti, string keretüüp="luukpära") //constructor kuna pole keskmist sõna
        {
            _mark = mark;
            _värv = värv;
            _istekohti = istekohti;
            _keretüüp = keretüüp;
            _veljeDiameeter = 17;
            _istmeMaterjal = "veluur";
            _kiirendus = 9;
            _tippkiirus = 200;
        }
        public string AnnaVärvus()
        {
            var tulemus = _värv;
            if(_metallikVärv)
            {
                tulemus += " metallik";
            }
            return tulemus;
        }
        public void MuudaVärv(string värv, bool onMetallik=false)
        {
            _värv = värv;
            _metallikVärv = onMetallik;
        }
        //Velgede diameetri muutmine
        public void MuudaVelge(int veljediameeter)
        {
            if(veljediameeter>0)
            {
                _veljeDiameeter = veljediameeter;
            }
        }
        //Istme kohtade muutmine
        public void MuudaKohta(int kohad)
        {
            //if (kohad < 0)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(kohad), "Istekohti ei tohi olla negatiivne arv.");
            //}
            _istekohti = kohad;
        }
        //Kuva kõik andmed
        public void Andmed()
        {
            Console.WriteLine($"Mark: {_mark}");
            Console.WriteLine($"Värv: {AnnaVärvus()}");
            Console.WriteLine($"Istekohti: {_istekohti}");
            Console.WriteLine($"Istme materjal: {_istmeMaterjal}");
            Console.WriteLine($"Keretüüp: {_keretüüp}");
            Console.WriteLine($"Veljesuurus: {_veljeDiameeter}");
            Console.WriteLine($"Kiirendus: {_kiirendus}");
            Console.WriteLine($"Tippkiirus {_tippkiirus}");
        }
        public void TuuniMootorit()
        {
            var muutuseprotsent = _random.Next(5)+_random.NextDouble();
            if (_random.Next(2)==0)
            {
                _kiirendus -= _kiirendus * muutuseprotsent / 100;
            }
            else
            {
                _kiirendus += _kiirendus * muutuseprotsent / 100;
            }
        }
        /// <summary>
        /// Täiustab istmematerjali - valib järgmise saadaoleva.
        /// </summary>
        /// <returns>kas täiustamine õnnestus</returns>
        public bool TäiustaSisustust()
        {
            string[] materjalid = { "linane", "veluur", "vinüül", "nahk", "alcantara", "veegan nahk" };

            var praegusePositsioon = Array.IndexOf(materjalid, _istmeMaterjal);
            if (praegusePositsioon == materjalid.Length-1)
            {
                return false;
            }
            _istmeMaterjal=materjalid[praegusePositsioon+1];
            return true;
        }
    }
}
