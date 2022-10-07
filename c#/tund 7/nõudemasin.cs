using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund_7
{
    internal class nõudemasin
    {
        private int _taldrikud;
        private int _pesemattataldrikud;
        private int _maxmahutavus;
        private bool _tabletonsisestatud;
        private Olek _olek;

        public nõudemasin(int maxmahutavus)
        {
            _maxmahutavus = maxmahutavus;
            _olek = Olek.Laadimine;
        }
        /// <summary>
        /// pane mustad taldrikud masinasse
        /// </summary>
        /// <param name="taldrikud">mitu taldrikud paned</param>
        /// <returns>mitu ei mahtunud</returns>
        public int täida(int taldrikud)
        {
            if (taldrikud>_maxmahutavus-_pesemattataldrikud)
            {
                _pesemattataldrikud = _maxmahutavus;
                var jääk = taldrikud - (_maxmahutavus - _pesemattataldrikud);
                return jääk;
            }
            _pesemattataldrikud += taldrikud;
            return 0;
        }
        public void lisapesutablet()
        {
            _tabletonsisestatud = true;
        }
        public void pesenõud()
        {
            if (_olek==Olek.Laadimine && _tabletonsisestatud)
            {
                _olek = Olek.Pesu;
                Console.WriteLine($"vee sissevõtt");
                Console.WriteLine("vee soendamine");
                Console.WriteLine("aine segatakse veega");
                _olek = Olek.Kuivatus;
                Console.WriteLine("kuivatamine");
                _olek= Olek.Lõpp;
            }
            else
            {
                throw new Exception($"Masin on vales olekus või tablet sisestamata. Olek: {_olek}; tablett sisestatud{_tabletonsisestatud}");
            }
        }
        public void Tühjenda()
        {
            if (_olek==Olek.Lõpp)
            {
                _pesemattataldrikud = 0;
                _tabletonsisestatud = false;
                _olek = Olek.Laadimine;
            }
            else
            {
                throw new Exception($"masin on vales olekus {_olek}");
            }
        }
        public void andmed()
        {
            Console.WriteLine(nameof(nõudemasin));
            Console.WriteLine($"Täituvus: {_pesemattataldrikud}/{_taldrikud}");
            Console.WriteLine($"Olek: {_olek}");
            //Console.WriteLine($"Tablett: {(_tabletonsisestatud?) "sees":'puudu'}");
        }
        //public nõudemasin(int taldrikud, int maxmahutavus, string mark)
        //{
        //    _taldrikud = taldrikud;
        //    _maxmahutavus = maxmahutavus;
        //    _mark = mark;
        //}
        //public void laadimine(int taldrikud, int maxmahutavus)
        //{
        //    if (maxmahutavus < taldrikud)
        //    {
        //        Console.WriteLine("ei mahu ära");
        //    }
        //}
        
    }
}
