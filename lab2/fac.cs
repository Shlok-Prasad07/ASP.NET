using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPlab2DU
{
    internal class fac
    {
        int id, age;
        string name;
        double height, weight;
        public void GetFacDetails()
        {
            Console.WriteLine("Enter faculty id");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter faculty name");
            name = Console.ReadLine();

            Console.WriteLine("Enter faculty age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter faculty height");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter faculty weight");
            weight = Convert.ToDouble(Console.ReadLine());

        }

        public void DisplayFacDetails()
        {
            Console.WriteLine("ID " + id);
            Console.WriteLine("name " + name);
            Console.WriteLine("age " + age);
            Console.WriteLine("height " + height);
            Console.WriteLine("weight " + weight);
        }
    }
}
