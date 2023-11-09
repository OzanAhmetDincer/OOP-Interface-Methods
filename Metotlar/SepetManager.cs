namespace Metotlar
{
    internal class SepetManager
    {
        // naming convention-> metod isminin ilk harfinin büyük olması gibi yazımsal kurallar.
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!: " + urunAdi);
        }
    }
}
