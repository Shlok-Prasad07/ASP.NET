using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ASPlab2DU
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //fac f = new fac();
            //f.GetFacDetails();
            //f.DisplayFacDetails();

            bankaccount b = new bankaccount();
            b.GetAccountDetails();
            b.DisplayAccountDetails();

            //3.Write program showing use of common methods of String class.

            //string a = "Darshan University";
            //string b = "Rajkot";

            //int len = a.Length;
            //Console.WriteLine("len = "+ len);

            //string string_con = string.Concat(a,b);
            //Console.WriteLine("string_con = " +string_con);

            //Boolean status = a.Equals(b);
            //Console.WriteLine("status = " + status);

            //Console.WriteLine("ToLower = " + a.ToLower());
            //Console.WriteLine("ToUpper = " + b.ToUpper());

            //string c = a.Substring(5);
            //Console.WriteLine("Substring = " + c);

            //4.Write a program to change the case of entered character.

            //Console.WriteLine("enter char:");
            //char op = Convert.ToChar(Console.ReadLine());
            //changes cc = new changes();
            //cc.change(op);


            //5.Write a program to Replace lower case characters to upper case and Vice-versa.

            //lower_upper l_u = new lower_upper();
            //l_u.lowerupper();
            //l_u.convert();


        }


    }
}
