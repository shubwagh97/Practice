using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Polymorphism
    {
        public static void Main()
        {
            HourlyBased HB = new HourlyBased(400,8,111,"shubham",777494);
            HB.salary();
            HB.sala();
            
            SalaryBased SB = new SalaryBased(1500,222,"abhi",80879);
            SB.salary();
            SB.sal();
            

        }
    }
    abstract class Teacher
    {
         public int Tid;
        public string Tname;
        public int mobileno;

        

        public Teacher(int Tid, string Tname, int mobileno)
        {
            this. Tid = Tid;
           this.Tname = Tname;
            this.mobileno = mobileno;
        }

       

        public abstract void salary();
    }
    class HourlyBased:Teacher
    {
        int rateperhr;
            int hrs;

        public HourlyBased(int rateperhr, int hrs,int Tid,string Tname,int mobileno) : base(Tid, Tname, mobileno)
        {
            

            this.rateperhr = rateperhr;
            this.hrs = hrs;
        }

        public override void salary()
        {
            Console.WriteLine("HB salary");

        }
        public void sala()
        {
            Console.WriteLine(rateperhr);
            Console.WriteLine(hrs);
            Console.WriteLine(Tid);
            Console.WriteLine(Tname);
            Console.WriteLine(mobileno);

        }

    }
    class SalaryBased:Teacher
    {
        int salary1;
        public SalaryBased(int salary1, int Tid, string Tname, int mobileno) : base(Tid, Tname, mobileno)
        {
            this.salary1 = salary1;
        }

        public override void salary()
        {
            Console.WriteLine("salary based :", salary1);
        }
        public void sal()
        {
            Console.WriteLine(salary1);
            Console.WriteLine(Tid);
            Console.WriteLine(Tname);
            Console.WriteLine(mobileno);
        }

    }
}

