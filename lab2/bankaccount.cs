using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPlab2DU
{
    internal class bankaccount
    {

        //Write a program to Create a class Bank_Account with Account_No, Email, User_Name, Account_Type and Account_Balance 
        //as data members.Also create a Member function GetAccountDetails() & DisplayAccountDetails(). 
        int no;
        string email,name, type;
        double balance;
        public void GetAccountDetails()
        {
            Console.WriteLine("Enter bank no , name , email , type , balance ");
            no = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter bank name");
            name = Console.ReadLine();

            //Console.WriteLine("Enter bank email");
            email = Console.ReadLine();

            //Console.WriteLine("Enter bank type");
            type = Console.ReadLine();

            //Console.WriteLine("Enter bank balance");
            balance = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("no " + no);
            Console.WriteLine("name " + name);
            Console.WriteLine("email " + email);
            Console.WriteLine("type " + type);
            Console.WriteLine("balance " + balance);
        }
    }
}
