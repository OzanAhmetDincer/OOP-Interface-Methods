namespace OOP2
{
    //Individual(Gerçek)
    internal class GercekMusteri : Musteri
    {
        public string TcNo { get; set; }// Burada sayısal olan bir ifadeyi string olarak tanımlamamızın sebebi bu sayı üzerinde matematiksel bir işlem yapmayacak olmamız. Bu property'i başka bir programda kullanınca farklılık oluşturmaması için en verimli olarak bu şekilde tanımlama yaparız. long veya başka türde tanımlasak da sıkıntı olmaz fakat en güzeli bu.
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
