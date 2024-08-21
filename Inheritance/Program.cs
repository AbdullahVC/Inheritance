using System;
namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Ahmet";
            ogrenci.Soyad = "Yılmaz";
            ogrenci.OgrenciNumarasi = 12345;
            ogrenci.OgrenciBilgisiYazdir();

            Console.WriteLine("--------------------------------------------------");

            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Ad = "Ayşe";
            ogretmen.Soyad = "Kaya";
            ogretmen.Maas = 5000.00m;
            ogretmen.OgretmenBilgisiYazdir();
        }
    }

}