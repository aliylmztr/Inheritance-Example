using System;

namespace InheritanceExample
{
    public class Kedi : Kopek
    {
        public void sesCikar()
        {
            Console.WriteLine("Kedi ses çıkarıyor...");
        }

        public void hayvanBilgileriGoster()
        {
            Console.WriteLine("Hayvan ismi: " + isim);
            Console.WriteLine("Hayvan rengi: " + renk);
            Console.WriteLine("Hayvan kilosu: " + kilo);
            Console.WriteLine("Hayvan ayak sayısı: " + ayakSayisi);
            Console.WriteLine("Hayvan cinsiyeti: " + cinsiyet);
        }
    }
}
