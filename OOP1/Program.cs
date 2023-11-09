using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

Product product2 = new Product
{
    Id = 2,
    CategoryId = 5,
    ProductName = "Kalem",
    UnitsInStock = 5,
    UnitPrice = 35,
};   



ProductManager productManager = new ProductManager();
productManager.Add(product1);// Burada ise "product1" olarak tanımladığımız değişkenin stack deki değeri yani heap memory deki adresini referans olarak yollarız. "Add" metodu içerisinde ise bu referans üzerinden "ProductName" değerini değiştirdiğimiz de ilk tanımladığımız "Masa" değeri değişir.
Console.WriteLine(product1.ProductName);//Kamera


int sayi = 100;
productManager.BirSeyYap(sayi);// "BirSeyYap" metodu içerisinde "sayi=99" dedik fakat burada ki değer ile bizim parametre olarak gönderdiğimiz değer farklı şeyler. Bizim parametre olarak gönderdiğimiz değer bu metot içerisinde ki değeri değiştirir sadece. Bizim program.cs içerisinde ki tanımladığımız değer ile alakası yok .
Console.WriteLine(sayi);//100








