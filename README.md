# Inheritance
#### Açıklama
Bu proje, C# dilinde kalıtım (inheritance) kavramını göstermektedir. `BaseKisi` adında bir ana sınıf oluşturulmuş olup, bu sınıftan türeyen `Ogrenci` ve `Ogretmen` sınıfları ile temel miras yapısı gösterilmektedir. Her iki alt sınıf da `BaseKisi` sınıfından miras alarak ek özellikler ve fonksiyonlar eklemektedir.

#### Özellikler
- **BaseKisi Sınıfı**:
  - `Ad` ve `Soyad` bilgilerini saklar.
  - Bu bilgileri konsola yazdıran bir metot içerir.

- **Ogrenci Sınıfı** (BaseKisi sınıfından türetilmiştir):
  - Ek olarak `OgrenciNumarasi` adlı bir özellik içerir.
  - Öğrenci numarası ile birlikte adı ve soyadı yazdıran bir metot içerir.

- **Ogretmen Sınıfı** (BaseKisi sınıfından türetilmiştir):
  - Ek olarak `Maas` adlı bir özellik içerir.
  - Maaş bilgisi ile birlikte adı ve soyadı yazdıran bir metot içerir.

#### Kullanılan Teknolojiler
- **C#**: Programlama dili olarak kullanılmıştır.
- **.NET Core veya .NET Framework**: Programın çalıştırılabilmesi için gereklidir.
- **Visual Studio** veya herhangi bir C# uyumlu IDE: Projenin geliştirilmesi ve çalıştırılması için önerilen araçlar.
