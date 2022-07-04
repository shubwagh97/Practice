using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class String1
    {
        public static void Main()
        {
            /* string a= "shubham";
             Console.WriteLine(a);*/

            /*string a = "shubham";
            Console.WriteLine(a.Length);*/


            /*string a = "shubham";
            int i = 0;
           while (i <= a.Length-1 )
            {
                Console.WriteLine(a[i]);
                i++;
            }
            Console.WriteLine();*/

            // reverse string
            /*string a = "shubham";
            int i = a.Length-1;
            while (i >= 0)
            {
                Console.WriteLine(a[i]);
                i--;
            }*/

            //count words
            /*string a = "shubham";
            int i = 0;
            int count = 0;
            
            while (i < a.Length)
            {

                count++;
                i++;
            }
            Console.WriteLine(count);*/


            // Compare two string
            /* string a = "shubham";
             string b = "shubham1";

             if (a == b && a.Length == b.Length)
             {
                 Console.WriteLine("equal");

             }
             else
             {
                 Console.WriteLine("not equal");
             }*/


            // count special chracter,digit,alphabet

            /*string a = "shubh@16gmail";
            int alp=0;
            int count2=0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 'a' && a[i] <= 'z')
                {
                    alp++;
                    Console.WriteLine("aplbhabets" + a[i]);
                }
                if (a[i] >= '1' && a[i] <= '9')
                {
                    count2++;
                    Console.WriteLine("digit " + a[i]);
                }
            }
            Console.WriteLine(alp);
            Console.WriteLine(count2);*/



            //copy i string to another string

            /* string a = "shubham";
             string[] str = new string[a.Length];
             for (int i = 0; i < a.Length; i++)
             {
                 string tmp = a[i].ToString();
                 str[i] = tmp;

             }
             Console.WriteLine("first " + a);
             Console.WriteLine(string.Join("", str));*/

            // consonat and vowels

            /*string a = "shubham";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    Console.WriteLine("vowel " + a[i]);
                }
                else
                {
                    Console.WriteLine("consonant " + a[i]);
                }
            }*/

            // highest frequency of character
            /* string a = "hello";
             int count=0;
                int b=0 ;
             char c;
             for (int i = 0; i < a.Length; i++)
             {

                 b = 0;
                 c = a[i];

                 for (int j = 0; j < a.Length; j++)
                 {
                     if (a[i] == a[j])
                     {
                         count++;
                         b += count;
                     }
                 }


                 if (b > count)
                 {
                     Console.WriteLine("highst " + c);
                 }
             }*/


            // sorting array in ascending order
            /*string a = "this is string";
            char[] chstr = a.ToCharArray();
            for (int i = 0; i < chstr.Length; i++)
            {
                for (int j = 0; j < chstr.Length-1; j++)
                {
                    if (chstr[j] > chstr[j + 1])
                    {
                        char temp = chstr[j];
                        chstr[j] = chstr[j + 1];
                        chstr[j + 1] = temp;

                    }
                }
            }*/
            // Console.WriteLine(chstr);


            // check whether substring is present in given string
            /*string a = "shubham is hero";
            string b = "is";
            bool m ;
            m = a.Contains(b);
            if (m)
            {
                Console.WriteLine("sub tring is present");
            }
            else
            {
                Console.WriteLine("not present");
            }*/


            // extract substring from given string

            /*string a = "shubham is hero";
            int pos=5;
            int l=12;
            string temp = "";
            for (int i = pos; i < l; i++)
            {
                temp += a[i].ToString();

            }
            Console.WriteLine(temp);*/

            //replace lowercase with uppercase

            /* string a = "Shubham is Hero";
             char temp;
             for (int i = 0; i < a.Length; i++)
             {
                 temp = a[i];
                 if (temp >='a' && temp<='z' )
                 {
                     Console.WriteLine(char.ToUpper(temp));

                 }
                 else
                 {
                     Console.WriteLine(char.ToLower(temp));
                 }
             }*/

            /* *
            ***
           *****
          *******
         *********
        ***********
       *************
      ***************
     *****************
    ********************/


            /*for (int i = 1; i <= 10; i++)
            {
                for (int space = 10; space >= i ; space--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 2; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            /*string a =Console.ReadLine();
            string b = Console.ReadLine();
            bool c;
            c = a.Contains(b);
            if (c)
            {
                Console.WriteLine("string is present");
            }
            int index = a.IndexOf(b);
            if (index < 0)
            {
                Console.WriteLine("substring no found");
            }
            else
            {
                Console.WriteLine("found '{0}' in '{1}' at pos {2}", b, a, index);
            }*/


            // arthmetic progression
            /* int a = 0;
             int d = 2;
             int n = 10;
             int c = 0;
             int sum = 0;
             for (int i = a; i < n; i++)
             {
                 c = a + d;
                 sum += c;
              Console.WriteLine(sum);
             }*/

            // count words,duplicate ,occurance
            /* Console.WriteLine("enetr string");
             string str = Console.ReadLine();
             string[] words = str.Split(" ");
             for (int i = 0; i < words.Length; i++)
             {
                 int count = 1;
                 bool isvisited = false;
                 for (int k = i-1; k>=0; k--)
                 {
                     if (words[i] == words[k])
                     {
                         isvisited = true;
                         break;
                     }

                 }
                 if (isvisited == false)
                 {
                     for (int j = i + 1; j < words.Length; j++)
                     {
                         if (words[i] == words[j])
                         {
                             count++;
                         }

                     }
                     if (count > 1)
                     {
                         Console.WriteLine(words[i] + " " + count);
                     }
                 }
             }*/

            //frequency of words and position
            /*string s = "india is my country is ods india";
            string c;
            int count = 0;
            string[] s1 = s.Split();
            for (int i = 0; i < s1.Length; i++)
            {
                c = s1[i];
                if (c == "india")
                {
                Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine(count);*/


            // insert a substring
            /* string a = "this is a string";
             string b = "original";
             string search = "string";
             string[] s1 = a.Split();
             int i;
             i = a.IndexOf(search);
             b =  " "+b.ToString()+" ";
             a = a.Insert(i, b);
             Console.WriteLine(a);*/

            //no of time substring appear in string

            /*string a = "india is my country india";
            string b = "is";
            string[] s1 = a.Split();
            int count = 0;
            for (int i = 0; i < s1.Length;i++)
            {
                if (b == s1[i])
                {
                    count++;

                }
            }
            Console.WriteLine(count);*/

            // duplicate word in string
            /*string a = "india is my country india is my";
            string[] s1 = a.Split();
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                count = 0;
                for (int j = i+1; j < s1.Length; j++)
                {
                    if (s1[i] == s1[j])
                    {
                        count++;
                       

                    }
                }

                if (count > 0 )
                {
                    Console.WriteLine(s1[i]+ count);
                }
            }*/

            // occurance of word
            /*string a = "india is my country india";
            string[] s1 = a.Split();
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                count = 1;
                for (int j = i+1; j < s1.Length; j++)
                {
                    if (s1[i] == s1[j])
                    {
                        count++;
                        
                    }
                }
                if (count>=1 )
                Console.WriteLine(s1[i] + " " + count);
            }*/

            //occurance of word
            /*string a = "india is my country india is";
            string[] s1 = a.Split();
            for (int i = 0; i < s1.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i-1; k >=0; k--)
                {
                    if (s1[i] == s1[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < s1.Length; j++)
                    {
                        if (s1[i] == s1[j])
                        {
                            count++;
                        }
                    }
                    if (count >= 1)
                    {
                        Console.WriteLine(s1[i] + " " + count);
                    }
                }

            }*/


            // remove the word from string
            /*string a = "india is my country";
            string c = a.Remove(0, 5);
            Console.WriteLine(c);*/

            Console.WriteLine("enter chars");
          

            
            




            



                    

                    

            
            




            
             





           
            
            
            
                
            




            
            
















            //write code to perform sum of even element in array.
            //to perform sum of array element.
            //minimum element from char type of array(int and char)
            //reverse char type of array
            // display alternate elemnt from array
            // sum of prime in  array.
















        }
    }
}

