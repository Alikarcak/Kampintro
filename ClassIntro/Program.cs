using System;

class Program
{
    public static void Main(string[] args)
    {
        string adi = "Ali";
        int yas = 36;

        kurs kurs1 = new kurs();
        kurs1.kursAdi = "c#";
        kurs1.Egitmen = "Ali Karçak";
        kurs1.IzlenmeOrani = 68;

        kurs kurs2 = new kurs();
        kurs2.kursAdi = "Java";
        kurs2.Egitmen = "Kerem Varış";
        kurs2.IzlenmeOrani = 65;

        kurs kurs3 = new kurs();
        kurs3.kursAdi = "Pyhton";
        kurs3.Egitmen = "Berkay Gürses";
        kurs3.IzlenmeOrani = 80;

        kurs kurs4 = new kurs();
        kurs4.kursAdi = "C++";
        kurs4.Egitmen = "Murat Kurtboğan";
        kurs4.IzlenmeOrani = 100;




        // Console.WriteLine(kurs1.kursAdi + " "+ kurs1.Egitmen);

        kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3, kurs4 };

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen);
        }
    }


    class kurs
    {
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
