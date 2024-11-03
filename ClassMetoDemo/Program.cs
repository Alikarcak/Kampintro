using ClassMetoDemo;

Musteri musteri1 = new Musteri();
musteri1.Adi = "Ali";
musteri1.Soyadi = "Karçak";
musteri1.Id = 0122563;


Musteri musteri2 = new Musteri();
musteri2.Adi = "Banu";
musteri2.Soyadi = "Güneş";
musteri2.Id = 0126685;




Musteri musteri3 = new Musteri();
musteri3.Adi = "Berkay";
musteri3.Soyadi = "Gürses";
musteri3.Id = 01446998;





Musteri musteri4 = new Musteri();
musteri4.Adi = "Engin";
musteri4.Soyadi = "Demiroğ";
musteri4.Id = 0122568;



Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };


foreach (var Musteri in musteriler)
{
    Console.WriteLine(Musteri.Adi);
    Console.WriteLine(Musteri.Soyadi);
    Console.WriteLine(Musteri.Id);
    Console.WriteLine("-------------------");
}


MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Sil(musteri2);


Console.WriteLine("----------------------");


musteriManager.Ekle(musteri3);
musteriManager.Listeleme(musteri4);







