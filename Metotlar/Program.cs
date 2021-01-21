using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            //type-safe--tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("----------metotlar----------");
            //instance - örnek
            SepetManager SepetManager = new SepetManager();
            SepetManager.Ekle(urun1);
            SepetManager.Ekle(urun2);

            SepetManager.Ekle2("Armut", "yesil armut", 12, 10);
            SepetManager.Ekle2("Elma", "yesil elma armut", 12, 9);
            SepetManager.Ekle2("Karpuz", "Diyarbakir karpuzu", 12, 8);


        }
    }
    class SepetManager
    {
        //naming convention
        //syntax

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebirkler.Sepete Eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyati, int stok)
        {
            Console.WriteLine("Tebirkle.Sepete Eklendi : " + urunAdi);
        }
    }

    class Urun
    {
        //property - özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
