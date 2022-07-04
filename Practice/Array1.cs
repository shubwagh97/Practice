using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Array1
    {
        public static void Main()
        {
            //store element and print
            /*int[] a = { 1, 2, 3, 4, 5 };
            foreach (int element in a)
            {
                Console.WriteLine(element);
            }*/

            /*int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i);
                
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();*/


            // display of value in array display in reverse order
            /* int[] arr = { 1, 2, 3 };
             for (int i = arr.Length - 1; i >= 0; i--)
             {
                 Console.WriteLine(arr[i]);
             }*/


            //sum of the array element
            /*int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            Console.WriteLine(sum);*/


            // copy elemnt form one array to anothere;
            /*int[] arr = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[] arr2 = new int[5];
            int temp = 0;
            int temp1 = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (i >= 1)
                {

                   temp = arr[i];
                   for (int j = 0; j < arr2.Length; j++)
                   {
                       arr2[j] = temp;
                       temp1 = arr2[j];

                   }
                   Console.WriteLine(temp1);
                }
            }*/


            //count duplicate array
            /*int[] arr = { 1, 2, 3, 4, 1, 2 };
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i-1; k >= 0; k--)
                {
                    if (arr[i] == arr[k])
                    {
                      isvisited = true;
                      break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    if (count >= 1)
                    {
                        Console.WriteLine(arr[i] + " " + count);
                    }
                }
            }*/

            //merrge 2 array in ascending order
            /* int[] arr1 = { 1, 2, 3, 4, 5, 6 };
             int[] arr2 = { 7, 8, 9, 1, 2, 3 };
             int[] arr3 = new int[arr1.Length + arr2.Length];
             int j = 0;
             for (int i = 0; i <= arr1.Length-1; i++)
             {
                 arr3[i] = arr1[i];
             }
             for (int i = arr1.Length; i < arr3.Length; i++)
             {

                 arr3[i] = arr2[j];
                 j++;
             }
             for (int i = 0; i < arr3.Length; i++)
             {
                 Console.WriteLine(arr3[i]);
             }*/


            // sort array in ascending order
            /*int[] a = { 5,4,3,2,1};
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
               for (int j = 0;j<a.Length-1;j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
                Console.WriteLine(a[i]);
            }*/

            // duplicate element in an array
            /*int[] a = { 1,2,3,4,5,1,3,4 };
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool isvisited = false;
                int count = 0;
                for (int k = i-1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i+1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            c = a[i];
                            count++;

                        }
                    }

                   if (count>0)
                   {

                      Console.WriteLine(c+" "+count);
                   }
                }

            }*/

            // print unique element
            /*int[] a = { 1, 1, 1, 5, 1 };
            
            for (int i = 0; i < a.Length; i++)
            {
                bool isvisited = false;
                int count = 1;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            
                            count++;
                            
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(a[i]+" "+count);
                    }
                }
            }*/

            /*int[] a = { 1, 1, 1, 2, 1, 1 };
            for (int i = 0; i < a.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }

                }
                if (count == 1)
                {
                    Console.WriteLine(a[i]);
                }
            }*/

            // merge array in sorted order
            /*int[] a = { 5, 4, 3, 2, 1 };
            int[] b = { 9, 8, 7, 6 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            int temp = 0;
           
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
                
            }
            for (int i =a.Length; i < c.Length; i++)
            {
                c[i] = b[j];
                
                j++;
            }
            for (int i = 0; i < c.Length; i++)
            {

            Console.WriteLine(c[i]);
            }



               
            for (int i = 0; i < c.Length; i++)
            {
                for (int k = 0; k < c.Length-1; k++)
                {
                    if (c[k] > c[k+1])
                    {
                        temp = c[k];
                        c[k] = c[k + 1];
                        c[k + 1] = temp;

                    }
                }
                Console.WriteLine(c[i]);
            }*/


           

























        }
    }
}
