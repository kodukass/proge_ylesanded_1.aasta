using System;

namespace tund8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kristjan = new isikukood("37902220320");
            var korrektne = new isikukood("37902220123");
            var vigane_kümnega = new isikukood("37902220111");
            Console.WriteLine($"oled sündind {kristjan.Annapäev()}. päeval");
            Console.WriteLine($"oled sündind {kristjan.Annakuu()}. kuul nimega {kristjan.Annakuunimi()}");
            Console.WriteLine($"oled sündind {kristjan.Annaaasta()}. aastal");
            Console.WriteLine($"sünnipäev on {kristjan.Annasünnipäev()}");
            Console.WriteLine($"{ kristjan.ArvutaViimaneNumber()}");
        }
    }
}
