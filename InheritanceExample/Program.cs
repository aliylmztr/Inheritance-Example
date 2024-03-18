using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.isim = "Minnoş";
            kedi.kilo = 3;
            kedi.renk = "Gri";
            kedi.cinsiyet = "Dişi";
            kedi.ayakSayisi = 4;

            kedi.sesCikar();
            kedi.hayvanBilgileriGoster();

            Console.ReadLine();
        }
    }
}
