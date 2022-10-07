
using System;

namespace tund9_2
{
    internal class Program
    {
        static void tulesünnale(IViisakas v)
        {
            v.koputauksele();
            v.tervita("vanaema");
        }
        static void Main(string[] args)
        {
            var inimene = new inimene(22);
            var laps = new laps(12);
            var koer = new koer(3);
            tulesünnale(inimene);
            tulesünnale(laps);
            tulesünnale(koer);
        }
    }
}
