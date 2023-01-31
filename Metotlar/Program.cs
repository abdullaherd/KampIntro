using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1= new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi= 10;

            Urun urun2= new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.Fiyati = 40;
            urun2.StokAdedi = 20;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
             
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("----------Metotlar---------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12 ,12);
            sepetManager.Ekle2("elma", "yeşil elma", 15 ,20);
            sepetManager.Ekle2("karpuz  ", "db karpuzu", 22 ,40);
        }
    }
}
