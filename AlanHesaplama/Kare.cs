public class Kare : BaseGeometrikSekil
{
    public override double AlanHesapla()
    {
        return Genislik * Yukseklik; // Kare için genişlik ve yükseklik aynı olduğu için
    }
}