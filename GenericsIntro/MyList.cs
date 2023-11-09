namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        // constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;// Geçici bir dizi oluşturduk. Bunun sebebi her seferinde yeni bir dizi oluşturacağımız zaman eski dizinin referansı kayboluyordu. Bu yüzden önceki dizide ki değerler gidiyordu. Bunun olmaması için ilk diziyi geçici bir diziye atarız ki o ilk dizinin referansını tutarak veriler yok olmasın 
            items = new T[items.Length + 1];// Dizimize ekleme işlemi yapacağımız zaman önceki var olan dizimizin eleman sayısının bir fazlası olması lazım. Bu yüzden ilk dizinin uzunluğuna 1 ekleriz. Direkt sabit bir değer vermeyiz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                //for döngüsünde de geçici olarak oluşturduğumuz dizi içerisinde ki eski değerleri yeni oluşturduğumuz dizi içerisine sırayla atarız
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;// Yeni dizimizin uzunluğunu arttırdığımız için içerisine yeni bir değer ekleyebiliriz. "items" dizisinin uzunluğunun 1 eksiği son index numarasını yani son elemanı verir.
        }
    }
}
