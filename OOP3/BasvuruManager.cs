namespace OOP3
{
    internal class BasvuruManager
    {
        // Tüm class'ların referansını barındıran "IKrediManager" interface'sinden bir parametre gönderirsek buraya hangi class dan değer gelirse gelsin, o class'a bürünüp o class içerisinde ki işlemleri yapar.
        //Method injection, burada parametre olarak verdiğim değerlerde tür belli değil, sadece soyut halleri var biz burada somut hallerini enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
