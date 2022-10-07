using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund_7
{
    internal class reha
    {
        private int _varrepikkus;
        private int _vahed;
        private string _varrematerjal;
        private string _rehamaterjal;

        public reha(int varrepikkus, int vahed, string varrematerjal, string rehamaterjal)
        {
            _varrepikkus = varrepikkus;
            _vahed = vahed;
            _varrematerjal = varrematerjal;
            _rehamaterjal = rehamaterjal;
        }
        public void VahetaVars(string materjal, int pikkus)
        {
            _varrematerjal = materjal;
            _varrepikkus = pikkus;
        }
        public void Vahetaots(string materjal, int varrematerjal)
        {
            _rehamaterjal = materjal;
            //_varrematerjal = varrematerjal;
        }
        public void SaeVarsLühemaks(int pikkus)
        {
            if (pikkus > _varrepikkus)
            {
                throw new ArgumentOutOfRangeException("vart ei saa rohkem lõigata");
            }
            else
            {
                _varrepikkus -= pikkus;
            }
        }
        public bool RehaOnSobiv(int inimesepikkus)
        {
            return inimesepikkus * 80 / 100 > _varrepikkus;
        }
        public static int ArvutaPulkadeArv(double pulgaDiameeter, double pulkadevahe,double rehaLaius)
        {           

            return (int)Math.Floor((rehaLaius-pulgaDiameeter)/(pulgaDiameeter+pulkadevahe)+1);
        }

    }
}
