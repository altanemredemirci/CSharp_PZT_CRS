using System;
using System.Collections.Generic;
using System.Text;

namespace _19_OOP_Generic_2_Overloading
{
    internal class Urun<T>
    {
        public T Fiyat { get; set; }
        public T KDV { get; set; }

        public Urun(T fiyat, T kdv)
        {
            Fiyat = fiyat;
            KDV = kdv;
        }
    }

    class Urun<T,K>
    {
        public T Fiyat { get; set; }
        public K KDV { get; set; }

        public Urun(T fiyat, K kdv)
        {
            Fiyat = fiyat;
            KDV = kdv;
        }
    }
}
