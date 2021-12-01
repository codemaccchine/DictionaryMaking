using System.Collections;

namespace DictionaryMaking
{
    public class MyDistionary<T1, T2> : IEnumerable where T2 : class
    {
        List<T1> list1 = new();
        List<T2> list2 = new();
        public MyDistionary()
        {
        }

        public MyDistionary(T1 key)
        {
            list1.Add(key);
            list2.Add(null);
        }

        public MyDistionary(T1 key, T2 value)
        {
            list1.Add(key);
            list2.Add(value);
        }

        public MyDistionary(MyDistionary<T1,T2> myDistionary)
        {
            list1 = myDistionary.list1;
            list2 = myDistionary.list2;
        }

        public int Count
        {
            get { return list1.Count; }
        }

        public void Add(T1 key, T2 value)
        {
            list1.Add(key);
            list2.Add(value);
        }

        public void Remove(T1 key)
        {
            int counter = 0;
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i].Equals(key))
                {
                    break;
                }
                counter++;
            }
            list1.RemoveAt(counter);
            list2.RemoveAt(counter);
        }

        public void RemoveAt(int index)
        {
            list1.RemoveAt(index);
            list2.RemoveAt(index);
        }

        public void Clear()
        {
            list1.Clear();
            list2.Clear();
        }

        public void ShowItems()
        {
            Console.WriteLine("\n---Dictionary'de bulunan elemanlar---");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine($"{i + 1}. eleman çifti :  { list1[i]} - {list2[i]}");
            }
            if (list1.Count == 0)
            {
                Console.WriteLine("Bu dictionary'de eleman yoktur");
            }
        }


        //MyDictionary yapısının foreach döngüsüyle itere edilebilmesini sağlar
        public IEnumerator GetEnumerator()
        {
            //return list1.GetEnumerator();
            for (int i = 0; i < list1.Count; i++)
            {
                yield return $"{list1[i]}-{list2[i]}";
            }
        }
    }
}
