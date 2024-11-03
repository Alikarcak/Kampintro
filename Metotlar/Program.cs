// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Claims;
using Metotlar;
{
    string urunAdi = "Elma";
    double fiyati = 15;
    string aciklama = "Amasya elması";


    Urun urun1 = new Urun();
    urun1.Adi = "Elma";
    urun1.Fiyati = 15;
    urun1.Aciklama = "Amasya Elması";

    Urun urun2 = new Urun();
    urun2.Adi = "karpuz";
    urun2.Fiyati = 80;
    urun2.Aciklama = "Adana karpuzu";

    Urun[] urunler = new Urun[] {urun1, urun2 };
    

    // type-safe--tip güvenli 
    foreach (Urun urun in urunler)
    {
        Console.WriteLine(urun.Adi);
        Console.WriteLine(urun.Fiyati);
        Console.WriteLine(urun.Aciklama);
        Console.WriteLine("----------------------");


    }
    
        Console.WriteLine("---------Metotlar------------");
    // İnstance - örnek    
    // encapsulation - kapsülleme ayrı ayrı düzensiz olacak bir yapıyı bir kapsüle sokma düzene sokma

        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);
        sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
        sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 15);
        sepetManager.Ekle2("Karpuz", "Adana Karpuz", 12, 8);
}

    

// Dont repeat yourself - DRY - Clean Code - Best Practice  
