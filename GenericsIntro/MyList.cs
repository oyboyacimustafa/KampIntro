﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>

    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add (T item)
        
        {
            T[] teamArray = items;
            item = new T[items.Length + 1];
            for (int i = 0; i < teamArray.Length; i++)
            {
                items[i] = teamArray[i];
            }


            items[items.Length - 1] = item;







            Console.ReadKey();
        }

    }
}
