using System;

class Program
{
    public static void Main(string[] args)
    {
        string kurs1 = "Yazılım Geliştirici Yetiştirme kampı";
        string kurs2 = "Programlamaya başlangıç için Temel kurs";
        string kurs3 = "java";



        // array dizi 

        string[] kurslar = new string[] { "Yazılım Geliştirici yetiştirme kampı", "Yazılımcılar için Temel Kurs", "Java","pyhton","C++" };


        for (int i = 0; i <kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }

        Console.WriteLine("fot bitti");

        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }

        Console.WriteLine("sayfa sonu - footer");
    }
}