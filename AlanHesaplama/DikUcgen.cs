public class DikUcgen : BaseGeometrikSekil
{
    public override double AlanHesapla()
    {
        return (Genislik * Yukseklik) / 2; // Dik üçgen için (genişlik x yükseklik) / 2
    }
}