using System;

class Program
{
    static void Main()
    {
        // Kare nesnesi oluşturuluyor ve değerler atanıyor
        Kare kare = new Kare
        {
            Genislik = 5,
            Yukseklik = 5
        };

        // Dikdörtgen nesnesi oluşturuluyor ve değerler atanıyor
        Dikdortgen dikdortgen = new Dikdortgen
        {
            Genislik = 7,
            Yukseklik = 4
        };

        // Dik Üçgen nesnesi oluşturuluyor ve değerler atanıyor
        DikUcgen dikUcgen = new DikUcgen
        {
            Genislik = 6,
            Yukseklik = 3
        };

        // Alan hesaplama ve yazdırma
        Console.WriteLine($"Kare Alanı: {kare.AlanHesapla()}");
        Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen.AlanHesapla()}");
        Console.WriteLine($"Dik Üçgen Alanı: {dikUcgen.AlanHesapla()}");
    }
}
