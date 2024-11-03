using System;

class Program
{
    
    public static void Main(string[] args)
    {
        // type safety - tip güveliği demek
        // Do not repeat yourselg - kendini tekrarlama 
        // değer tutucu 

        string kategoriEtieti = "kategoriler";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMi = true;
        double dolarDun = 7.55;
        double dolarBugun = 7.45;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("Azalış butonu");
        }
        else if (dolarDun<dolarBugun)
        {
            Console.WriteLine("Artış butonu");
        }
        else
        {
            Console.WriteLine("Eşittir butonu");
        }
        

        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı ayarlarlar butonu");
        }
        else 
        {
            Console.WriteLine("Giriş yap butonu");
        
        
        } 

        


        Console.WriteLine(kategoriEtieti);
        

    } 
}

