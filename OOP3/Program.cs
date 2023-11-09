using OOP3;


/*IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
//IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); interface'lerde o interface'yi implamente eden class'ın referans numarasını tutabilir.
ihtiyacKrediManager.Hesapla();

TasitKrediManager tasitKrediManager = new TasitKrediManager();
//IKrediManager tasitKrediManager = new TasitKrediManager();
tasitKrediManager.Hesapla();

KonutKrediManager konutKrediManager = new KonutKrediManager();
//IKrediManager konutKrediManager = new KonutKrediManager();
konutKrediManager.Hesapla();*/




IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

// "BasvuruManager" class'ına "IKrediManager" türünden parametre tanımladığımız için ve bu interface'i diğer class'lan implamente ettiği için "KonutKrediManager" türünden bir class'ı değer olarak gönderebiliriz. 

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(new EsnafKredisiManager(), databaseLoggerService);
//basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());
//basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()});



List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
basvuruManager.KrediOnBilgilendirmesiYap(krediler);





