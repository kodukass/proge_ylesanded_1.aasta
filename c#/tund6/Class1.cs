using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund6
{
    //1.klassi loomine
    internal class Punkt
    {
        //2. väljade loomine
        private int _x;
        private int _y;
        private int _z;
        private int _nr;
        //klassimuutuja
        private static int _loendur = 0;
        //3. konstruktori loomine
        public Punkt(int x, int y, int z)
        {
            //4. väljade algväärtustamine
            _x = x;
            _y = y;
            _z = z;
            _loendur++;
            _nr = ++_loendur;
        }
        //5. tee midagi kasuliku
        public int GetX() { return _x; }
        public void SetX(int x) { _x = x; }
        public int GetY() { return _y; }
        public int GetZ() { return _z; }
        public double GetKaugusNullist() { return Math.Sqrt(_x*_x+_y*_y+_z*_z); }
        public static void KuvaPunktideKogus()
        {
            Console.WriteLine($"programmis on loodud {_loendur} punkti klassi isendit");
        }
    }
}
