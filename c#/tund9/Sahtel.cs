namespace tund9
{
    internal class Sahtel
    {
        private bool _onlukustatav;
        private bool _onvalepõhi;
        private byte _pikkus;
        private byte _laius;
        private byte _kõrgus;
        private static uint _sahtlitekoguarv = 0;

        public Sahtel(byte pikkus,byte laius,byte kõrgus,bool onlukustatav=false,bool onvalepõhi=false)
        {
            _pikkus = pikkus;
            _laius = laius;
            _kõrgus = kõrgus;
            _onlukustatav = onlukustatav;
            _onvalepõhi = onvalepõhi;
            if (++_sahtlitekoguarv%10==0)
            {
                _onvalepõhi=true;
            }
        }
        public override string ToString()
        {
            return $"sahtel:{_pikkus}x{_kõrgus}x{_laius}; {_onlukustatav}lukustatav; {_onvalepõhi}.";
        }
    }
}