

//string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil"};
//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[3]);



//isimler = new string[5];
//isimler[4] = "İlker";
//Console.WriteLine(isimler[4]);
//Console.WriteLine(isimler[0]);// Burada değeri göremeyiz çünkü isimler dizisini tekrardan "new" lersek farklı bir adreste yeni bir yer oluşturur. Önceden oluşturulmuş verileri göremeyiz.




List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("İlker");
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);// Dizilerde olduğu gibi burada ekleme yapınca dizilerde ki sıkıntıyı yaşamayız. İlk oluşturduğumuz liste üzerine ekleme yapabiliriz.






