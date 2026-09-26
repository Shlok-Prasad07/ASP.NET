using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPlab2DU
{
    internal class lower_upper
    {
        String input;
        String result = "";
        public void lowerupper()
        {
            Console.Write("Enter a string: ");
            input = Console.ReadLine();
        }
        public void convert()
        {
            foreach (var c in input)
            {
                if (Char.IsLower(c))
                {
                    result = result + Char.ToUpper(c);
                }
                else if (Char.IsUpper(c))
                {
                    result = result + Char.ToLower(c);
                }
                else
                {
                    result = result + c;
                }
            }
            Console.WriteLine(result);
        }

    }
}
