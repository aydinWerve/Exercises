using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{

    class MyDictionary<TKey, TValue>
    {
        TKey[] items; //string[] items; gibi düşünülebilir
        TValue[] items2;

        public MyDictionary()
        {
            items = new TKey[0]; // Default olarak başlangıçta boş bir dictionary tanımlıyoruz heap de
            items2 = new TValue[0];

        }
        public void Add(TKey item, TValue item2)
        {
            TKey[] tempArray = items; // önceki değerleri kaybetmemek için geçicide tutuyoruz
            TValue[] tempArray2 = items2;

            items = new TKey[items.Length + 1]; 
            items2 = new TValue[items2.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                items2[i] = tempArray2[i];
            }

            items[items.Length - 1] = item;
            items2[items2.Length - 1] = item2;

        }

        public void List()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i] + " " + items2[i]);
            }
        }
    }

}
