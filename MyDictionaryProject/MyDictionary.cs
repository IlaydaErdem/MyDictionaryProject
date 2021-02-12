using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryProject
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] items1;
        TValue[] items2;

        public MyDictionary()
        {
            items1 = new TKey[0];
            items2 = new TValue[0];
        }

        public void Add(TKey item1 , TValue item2)
        {
            TKey[] tempArray1 = items1;
            TValue[] tempArray2 = items2;

            items1 = new TKey[items1.Length + 1];
            items2 = new TValue[items2.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                items1[i] = tempArray1[i];
                items1[items1.Length - 1] = item1;
            }

            for (int j = 0; j < tempArray2.Length; j++)
            {
                items2[j] = tempArray2[j];
                items2[items2.Length - 1] = item2;
            }
  
        }

    }

   
}
