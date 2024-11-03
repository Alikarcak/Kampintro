using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetoDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi"   + " " +musteri.Adi +" "+ musteri.Soyadi +"  " + musteri.Id);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi"    +" "+ musteri.Adi + " " + musteri.Soyadi +"  "+ musteri.Id);
        }

        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi"  +" " + musteri.Adi + " " + musteri.Soyadi + "  " + musteri.Id);
        }
    }
}
