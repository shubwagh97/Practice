using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Pattern
    {
        public static void Main()

        {
            p1 A = new p1(20);
            A.Add();
            p2 B = new p2(20, 30);
            B.Sub();

            /*1
1 2
1 2 3
1 2 3 4
1 2 3 4 5
1 2 3 4 5 6
1 2 3 4 5 6 7
1 2 3 4 5 6 7 8
1 2 3 4 5 6 7 8 9*/

            /*for (int r = 1; r <= 9; r++)
            {
                for(int space=9;space>=r;space--)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c+" ");
                }
                Console.WriteLine();
            }*/



            /*
                *********
                *       *
                *       *
                *       *
                *********
                *       *
                *       *
                *       *
                *       **/


            /*for (int r = 1; r <= 9; r++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    if ((r==5 || c==9)||(r==1 || c==1)||(r <=9 && c ==9))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }*/
        }
        class p1
        {
            public int a;
            public p1(int a)
            {
                this.a = a;
            }
            public void Add()
            {
                Console.WriteLine(a);
            }

        }
        class p2:p1
        {
            int b;
            public p2(int b,int a):base(a)
            {
                
                this.b = b;
            }
            public void Sub()
            {
                Console.WriteLine(a + " " + b);
            }
        }
    }
}
