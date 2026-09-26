using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace exclassproDu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.WAP to print factorial of the given number.

            /*Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }*/



            //2.WAP to print whether perfect or not.

            /*Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            // Check if sum of divisors is equal to the number
            if (sum == n)
            {
                Console.WriteLine("is a Perfect Number.");
            }
            else
            {
                Console.WriteLine("is NOT a Perfect Number.");
            }*/


            //3.prime or not prime.

            /* Console.Write("Enter a number: ");
             int n = int.Parse(Console.ReadLine());
             int count = 0;
             if (n <= 1)
             {
                 Console.WriteLine("is NOT a Prime Number.");
                 return;
             }
             for (int i = 2; i < n; i++)
             {
                 if (n % i == 0)
                 {
                     count++;
                 }
             }
             if (count == 0)
             {
                 Console.WriteLine("is a Prime Number.");
             }
             else
             {
                 Console.WriteLine("is NOT a Prime Number.");
             } */


            //4. Find 2nd Largest Among 3 Numbers

            /* Console.Write("Enter first number: ");
             int a = int.Parse(Console.ReadLine());

             Console.Write("Enter second number: ");
             int b = int.Parse(Console.ReadLine());

             Console.Write("Enter third number: ");
             int c = int.Parse(Console.ReadLine());

             if ((a > b && a < c) || (a > c && a < b))
             {
                 Console.WriteLine("Second largest number is: " + a);
             }
             else if ((b > a && b < c) || (b > c && b < a))
             {
                 Console.WriteLine("Second largest number is: " + b);
             }
             else
             {
                 Console.WriteLine("Second largest number is: " + c);
             } */



            //5. palindrome or not

            /* Console.Write("Enter a number: ");
            int original = int.Parse(Console.ReadLine());
            int reversed = 0, temp = original;
            while (temp > 0)
            {
                int digit = temp % 10;
                reversed = reversed * 10 + digit;
                temp /= 10;
            }
            if (original == reversed)
            {
                Console.WriteLine($"{original} is a Palindrome.");
            }
            else
            {
                Console.WriteLine($"{original} is NOT a Palindrome.");
            } */


            //int x = 5 + 5;
            //int y = 10 + x;
            //int z = x + y;
            //Console.WriteLine(z);

            c obj = new c();
            obj.m1();
            //obj.m2();
            obj.m3();
        }
    }

    class a
    {
        public void m1()
        {
            Console.WriteLine("m1");
        }

    }

    class b : a
    {
        public void m2()
        {
            Console.WriteLine("m2");
        }

    }

    class c : a 
    {
        public void m3()
        {
            Console.WriteLine("m3");
        }

    }
}
