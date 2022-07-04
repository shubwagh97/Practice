using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Java
    {
        public static void Main()
        {
            Person A = new Person(111,"shubham","mophed",222,"activa");
            Console.WriteLine(A.id);
            Console.WriteLine(A.name);
            Console.WriteLine(A.vehicle);
            Console.WriteLine(A.vid);
            Console.WriteLine(A.vname);
            Person B = new Person(333,"abhishek","bike",444,"pulsar");
            Console.WriteLine(A.id);
            Console.WriteLine(A.name);
            Console.WriteLine(A.vid);
            Console.WriteLine(A.vehicle);
            Console.WriteLine(A.vname);

        }
    }
    class Vehicle
    {
        public int vid;
        public string vname;

        public Vehicle(int vid, string vname)
        {
            this.vid = vid;
            this.vname = vname;
        }
    }
    class Person:Vehicle
    {
        public int id;
        public string name;
        public string vehicle;

        public Person(int id, string name, string vehicle,int vid,string vname):base(vid,vname)
        {
            this.id = id;
            this.name = name;
            this.vehicle = vehicle;
        }
        
    }
}
