using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] tkeys;
        Tvalue[] tvalues;
        public MyDictionary()
        {
            tkeys = new Tkey[0];
            tvalues = new Tvalue[0];
        }
        public void Add(Tkey key,Tvalue value)
        {
            Tkey[] keyTemp = tkeys;
            Tvalue[] valueTemp = tvalues;
            tkeys = new Tkey[tkeys.Length + 1];
            tvalues = new Tvalue[tvalues.Length + 1];
            for (int i = 0; i < tkeys.Length; i++)
            {
                tkeys[i] = keyTemp[i];
            }
            for (int j = 0; j < tvalues.Length; j++)
            {
                tvalues[j] = valueTemp[j];
            }
            tkeys[tkeys.Length - 1] = key;
            tvalues[tvalues.Length - 1] = value;
           

        }
    }
}
