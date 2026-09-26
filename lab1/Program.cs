using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPlabDU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //question no -1

            //Console.WriteLine("Name : Shlok Prasad");
            //Console.WriteLine("Address :Ravapur Morbi");
            //Console.WriteLine("Contact Number : 9427236054");
            //Console.WriteLine("City : Morbi");

            //question no-2 
            //Area of Square

            //int s;
            ////Console.WriteLine("Area of Square :: ");
            //Console.WriteLine("Enter side of Square :: ");
            //s = Convert.ToInt32(Console.ReadLine());
            //int ans = s * s;
            ////Console.WriteLine(ans);

            ////Area of Rectangle
            //int l, b;
            ////Console.WriteLine("Area of Rectangle :: ");
            //Console.WriteLine("Enter l & b :: ");
            //l = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine("Enter breath of Rectangle :: ");
            //b = Convert.ToInt32(Console.ReadLine());
            //int anss = l * b;
            ////Console.WriteLine(anss);

            ////Area of Circle
            //double r;
            ////Console.WriteLine("Area of Circle :: ");
            //Console.WriteLine("Enter Radius :: ");
            //r = Convert.ToDouble(Console.ReadLine());
            //double ansss = 3.14 * r * r;
            //Console.WriteLine("Sqaure"+ans);
            //Console.WriteLine("Rectangle"+anss);
            //Console.WriteLine("Circle"+ansss);


            //question no -3 
            //double a, b, c;
            //Console.WriteLine("Enter A & B value ");
            //a = Convert.ToDouble(Console.ReadLine());
            ////Console.WriteLine("Enter B number here ::");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("1.ADD \n2.SUB \n3.DIVISION \n4.MULTIPLICATION");
            //c = Convert.ToDouble(Console.ReadLine());
            //double ans = 0;
            //switch (c)
            //{
            //    case 1:
            //        ans = a + b;
            //        break;
            //    case 2:
            //        ans = a - b;
            //        break;
            //    case 3:
            //        ans = a / b;
            //        break;
            //    case 4:
            //        ans = a * b;
            //        break;
            //    default:
            //        Console.WriteLine("Enter num b/w 1 to 4");
            //        break;
            //}
            //Console.WriteLine("ans " + ans);

            //if (c == 1)
            //{
            //    ans = a + b;
            //    Console.WriteLine(ans);
            //}
            //else if (c == 2)
            //{
            //    ans = a - b;
            //    Console.WriteLine(ans);
            //}
            //else if (c == 3)
            //{
            //    ans = a / b;
            //    Console.WriteLine(ans);
            //}
            //else if (c == 4)
            //{
            //    ans = a * b;
            //    Console.WriteLine(ans);
            //}
            //else
            //{
            //    Console.WriteLine("Enter num b/w 1 to 4");
            //}

            //question-4  method - 1 

            //double f,t;
            //Console.WriteLine("Enter celsius");
            //t = Convert.ToDouble(Console.ReadLine());
            //f = (t * 9 / 5 + 32);
            //Console.WriteLine("ans"+f);

            //double c, v;
            //Console.WriteLine("Enter fahrenheit");
            //v = Convert.ToDouble(Console.ReadLine());
            //c = (v - 32) * (5 / 9);
            //Console.WriteLine("ans"+c);


            //// method -2 
            //Console.WriteLine("Enter celsius :");
            //double cel = Convert.ToDouble(Console.ReadLine());

            //double celsius = (cel * 9 / 5) + 32;
            //Console.WriteLine("ans " + celsius);

            //Console.WriteLine("Enter fahrenheit :");
            //double fer = Convert.ToDouble(Console.ReadLine());

            //double fahrenheit = ((fer - 32) * 5) / 9;
            //Console.WriteLine("ans " + fahrenheit);

            //question-5

            double p, r, n, ans;

            //Console.WriteLine("Enter P,R,N here :");
            //p = Convert.ToDouble(Console.ReadLine());
            ////Console.WriteLine("Enter R number here ::");
            //r = Convert.ToDouble(Console.ReadLine());
            ////Console.WriteLine("Enter N number here ::");
            //n = Convert.ToDouble(Console.ReadLine());

            //ans = (p * r * n) / 100;
            //Console.WriteLine("ans " + ans);

            //question-6

            double a, b, c;
            Console.WriteLine("Enter A , B , C :");
            a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter B number here ::");
            b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter C number here ::");
            c = Convert.ToDouble(Console.ReadLine());

            double max = ((a > b) ? ((a > c) ? a : c) : b);
            Console.WriteLine(max);





        }
    }
}