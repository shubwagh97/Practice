using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
     class Sealed
    {
        public static void Main()
        {
            p1 a = new c2();
            a.Add();

        }
    }
    class p1
    {
        public virtual void Add()
        {
            Console.WriteLine("parent method");
        }
    }
   sealed class c1: p1           // by appying seal to class u cannot inherit that class.
    {
        public sealed override void Add()       // by appying seal to method u cammot override
                                                // that method
        {
            Console.WriteLine("child1 method");
        }
    }
    class c2
    {
        public void Add1()
        {
            Console.WriteLine("c2 method");
        }
    }
}
