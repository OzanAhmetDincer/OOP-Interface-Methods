namespace OOP2
{
    //Coorporate(Tüzel)
    // "TuzelMusteri : Musteri" şeklinde bir yazım "TuzelMusteri" class'ının "Musteri" class'ından miras aldığını gösterir.(inheritance)
    internal class TuzelMusteri : Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
