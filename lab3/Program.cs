using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASDULab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program to calculate area of a Rectangle using constructor.

            //areaofrectangle obj = new areaofrectangle(5, 5);
            //obj.area();


            //2.Write a program for implementing single inheritance.

            //B obj = new B();
            //obj.m1();
            //obj.m2();

            //3. Write a program to Create a divide by zero exception and handle it.

            //Console.WriteLine("Enter a here");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter b here");
            //int b = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    int c = a / b;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Plz dont enter 0 {0}", ex.Message);
            //}


            //4.Write a program that reads 5 numbers from user.Demonstrate concept of IndexOutOfRange Exception.

            Console.WriteLine("Enter element here :: ");
            int[] a = new int[5];
            try
            {
                for (int i = 0; i < 7; i++)
                {
                    a[i] = i;
                    Console.WriteLine(a[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("enter only 5 element {0}", ex.Message);
            }


            //question-5 

            //Student obj = new Student(23020201134,"Shlok Prasad",5,9.14,9.05);
            //obj.DisplayStudentDetails();



            //6.Write a program to De ne a class Salary which will contain member variable Basic, TA, DA, HRA. Write a program using 
            //Constructor with default values for DA and HRA and calculate the salary of employee.

            //Salary obj = new Salary(100,500);

        }

        //question-1

        //public class areaofrectangle
        //{
        //    int l, b;
        //    public areaofrectangle(int l, int b)
        //    {
        //        this.l = l;
        //        this.b = b;
        //    }

        //    public void area()
        //    {
        //        int rec = l * b;
        //        Console.WriteLine("areaofrectangle = " + rec);
        //    }
        //}


        //question-2

        //public class A
        //{
        //    public void m1()
        //    {
        //        Console.WriteLine("Method-1");
        //    }
        //}

        //public class B : A
        //{
        //    public void m2()
        //    {
        //        Console.WriteLine("Method-2");
        //    }
        //}

        //question-5 

        //public class Student
        //{
        //    public long Enrollment_No;
        //    public string Student_Name;
        //    public int Semester;
        //    public double CPI;
        //    public double SPI;

        //    public Student(long enrollment_No, string student_Name, int semester, double cPI, double sPI)
        //    {
        //        Enrollment_No = enrollment_No;
        //        Student_Name = student_Name;
        //        Semester = semester;
        //        CPI = cPI;
        //        SPI = sPI;
        //    }

        //    public void DisplayStudentDetails()
        //    {
        //        Console.WriteLine("Enrollment_No :: "+ Enrollment_No);
        //        Console.WriteLine("Student_Name :: "+ Student_Name);
        //        Console.WriteLine("Semester :: " + Semester);
        //        Console.WriteLine("CPI :: " + CPI);
        //        Console.WriteLine("SPI :: " + SPI);
        //    }
        //}


        // question-6

        //public class Salary
        //{
        //    public int Basic, TA, DA, HRA;

        //    public Salary(int basic, int tA, int dA=20100, int hRA=52000)
        //    {
        //        Basic = basic;
        //        TA = tA;
        //        DA = dA;
        //        HRA = hRA;
        //        int total = Basic + TA + DA + HRA;
        //        Console.WriteLine("Total salary : "+total);
    }

}
