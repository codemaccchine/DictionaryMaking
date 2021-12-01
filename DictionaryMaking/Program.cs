// See https://aka.ms/new-console-template for more information

namespace DictionaryMaking // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //parametresiz default constructor
            MyDistionary<int,string> myDistionary = new MyDistionary<int,string>(); 

            myDistionary.Add(01, "Adana");  //dictionary yapısına ekleme işlemi yapar
            myDistionary.Add(06, "Ankara");
            myDistionary.Add(07, "Antalya");
            myDistionary.Add(34, "İstanbul");
            myDistionary.Add(35, "İzmir");

            //IEnumerable interface'nin implemente edilmesi sayesinde foreach döngüsünde kullanılabilir
            foreach (var item in myDistionary)
            {
                Console.WriteLine(item);
            }

            MyDistionary<int,string> myDistionary2 = new MyDistionary<int, string>();
            myDistionary2 = myDistionary;
            myDistionary2.ShowItems();  //dictionary'de bulunan değer çiftlerini ekrana yazdırır

            myDistionary2.RemoveAt(0);  //index numarasına göre silme işlemi yapar
            myDistionary.ShowItems();

            myDistionary2.Remove(07);   //key değerine göre eleman çifti siler
            myDistionary2.ShowItems();

            myDistionary2.Clear();      //tüm değer çiftlerini siler
            myDistionary2.ShowItems(); 

            //nesne ayağa kalkarken eleman ekleme, parametreli constructor (string,string)
            MyDistionary<string,string> myDistionary3 = new MyDistionary<string, string>("book","kitap");
            myDistionary3.Add("door", "kapı");
            myDistionary3.Add("pencil", "kalem");
            myDistionary3.Add("school", "okul");
            myDistionary3.ShowItems();


            //aynı tipten bir nesnenin referansıyla(key ve value verilerini tutan listelerin referansını ileterek),
            //parametreli constructor (MyDictionary <string,string>)
            MyDistionary<string, string> myDistionary4 = new MyDistionary<string, string>(myDistionary3);
            myDistionary4.ShowItems();


            Console.ReadLine();
        }
    }
}
