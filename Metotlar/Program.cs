// Dont repeat yourself (DRY)
// Aynı kod satırlarını farklı yerlerde sık sık kullanmak bizim kod tekrarı yapmamıza neden olur ve boşa yazmış oluruz. Başka bir zaman bu kodlarda değişiklik yapmak istediğimiz zaman bu kodları kullandığımız tüm yerlerde değişiklik yapmak zorunda kalırız. Bunu önlemek için metotları kullanırız. Tek bir yerden yapılan değişiklik her yerde etkili olur.



using Metotlar;

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 20;
urun1.Aciklama = "Amasya Elması";


Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";


Urun[] urunler = new Urun[] {urun1,urun2 };

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("***************************");
}



Console.WriteLine("************Metotlar*********************");

//Instance (örnek). Aşağıda olduğu gibi farklı class'ları kullanabilmek için bu class sınıfından bir nesne oluşturmalıyız. Bu örneklemeye instance denir

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);


//Encapsulation. Aşağıda ki gibi değerleri tek tek vermek yerine "Urun" adında bir class oluşturup, özellikleri bu class içerisinde tanımlayıp değer atamalarını bunun üzerinden yapabiliriz. Buna "encapsolation" denir. Yani özellikleri(ad,fiyat vb.) bir yerde toplamak. kapsüllemek. Böylelikle olası bir değişiklikte tek tek değişiklikleri her sayfada yapmaktansa Urun classı içerisinde yaparız ve bitiririz.
sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);





