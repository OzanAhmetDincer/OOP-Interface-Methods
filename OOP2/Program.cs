using OOP2;


// Gerçek Müşteri

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "123456";
musteri1.Adi = "Ozan";
musteri1.Soyadi = "Kadi";
musteri1.TcNo = "12345678985";

// Tüzel Kişi

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "54321";
musteri2.SirketAdi = "Kodlama.io";
musteri2.VergiNo = "1324648945489";


// İnheritance olayını yapmamızın asıl  sebebi "Musteri" class'ında tanımladığımız değerlerin bu sınıftan miraz alanlarda da olmasından ziyade, "Musteri" class'ının "GercekMusteri" ve "TuzelMusteri" class'lrınında referanslarını tutabilmesidir. "Musteri" base class'tır yani referans tutucudur.
Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);
musteriManager.Ekle(musteri4);































