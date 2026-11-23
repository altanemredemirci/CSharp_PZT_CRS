using System;
using System.Collections.Generic;
using System.Text;

namespace _17_OOP_3_Inheritance_3
{
    internal class B:A
    {
        public int b { get; set; }

        public B()
        {
            Console.WriteLine("B sınıfının constructor metodu çalıştı.");
        }
    }
}
