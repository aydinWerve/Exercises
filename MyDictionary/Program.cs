using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> isimler = new MyDictionary<int,string>();
            isimler.Add(1, "Merve");
            isimler.Add(2, "Aydın");

            isimler.List();

        }
    }
}
