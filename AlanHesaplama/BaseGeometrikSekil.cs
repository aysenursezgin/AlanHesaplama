public abstract class BaseGeometrikSekil
{
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }

    // Alan hesaplama metodunu soyut olarak tanımlıyoruz.
    public abstract double AlanHesapla();
}