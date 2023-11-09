namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        public void BirSeyYap(int sayi)
        {
            sayi = 99;
        }
    }
}
