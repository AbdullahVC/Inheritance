using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void KisiBilgisiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }

    class Ogrenci : BaseKisi
    {
        public int OgrenciNumarasi { get; set; }

        public void OgrenciBilgisiYazdir()
        {
            KisiBilgisiYazdir();
            Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
        }
    }

    class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }

        public void OgretmenBilgisiYazdir()
        {
            KisiBilgisiYazdir();
            Console.WriteLine($"Maaş: {Maas} TL");
        }
    }
}
