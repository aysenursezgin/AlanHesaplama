public class Dikdortgen : BaseGeometrikSekil
{
    public override double AlanHesapla()
    {
        return Genislik * Yukseklik; // Dikdörtgen için genişlik x yükseklik
    }
}