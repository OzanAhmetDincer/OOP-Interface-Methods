namespace OOP1
{
    internal class Product
    {
        public int Id { get; set; }// Bir nesneyi diğerinden ayırt edebilmek için kullandığımız alandır
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }// Ürünün stok adedi
    }
}
