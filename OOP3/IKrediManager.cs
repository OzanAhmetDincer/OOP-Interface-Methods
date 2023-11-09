namespace OOP3
{
    // İnterfaceler bir şablon görevi görür. Aşağıdaki "Hesapla" metodu her kredide var fakat her birinde farklı şekilde hesaplanıyor. Burada yaptığımız şey "IKrediManager" interface'yi kullanan class'lar bu interfacec içerisinde ki metotları barındırmak zorunda. Sonrasın da class içerisinde bu metotları doldururuz. Kuralları içerir.
    internal interface IKrediManager
    {
        void Hesapla();
        void BirseyYap();
    }
}
