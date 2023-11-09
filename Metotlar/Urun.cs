namespace Metotlar
{
    internal class Urun
    {
        // property (özellik)
        public int Id { get; set; }// Her bir ürünü yada ne tür bir class tanımlandıysa ıd ile her bir yapıyı özelleştiririz. Eşsiz birer değer oluşur 
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
