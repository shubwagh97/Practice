using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
     class Object1       // predefined object class is a parent class for all the classes.
    {

        public static void Main()
        {
            pp1 A = new pp1(20,"shubham");
            Console.WriteLine(A);


            PermanentTeacher1 B = new PermanentTeacher1("shubhs",20,12345);
                                                                          // abstrct classs 
            B.name1();
            B.teacher1();







        }
    }
    class pp1
    {
        int age;
        string name;

        public pp1(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public override string ToString()
        {
            return $"name:{name} age:{age}";
        }
        public void Sub()
        {
            Console.WriteLine("shubh");
            
        }
    }


    // abstrct class and method

    abstract class Teacher1
    {
        string name;
        int salary;

        public Teacher1(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public void teacher1()
        {
            Console.WriteLine("abstrct class instance method");
        }

        public abstract void Add();
    }
    class PermanentTeacher1 : Teacher1
    {
        int PTid;
        public PermanentTeacher1(string name, int salary,int PTid) : base( name, salary)
        {
           
           this. PTid = PTid;


        }
       
        public void name1()
        {
            Console.WriteLine( PTid);
        }
        public override void Add()
        {
            Console.WriteLine("abstrct method");
        }
    }
}
