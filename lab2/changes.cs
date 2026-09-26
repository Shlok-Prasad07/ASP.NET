using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPlab2DU
{
    internal class changes
    {
        char op;
        public void change(char op)
        {
            if (char.IsLower(op))
            {
                Console.WriteLine("upper case:" + char.ToUpper(op));
            }
            else
            {
                Console.WriteLine("upper case:" + char.ToLower(op));
            }
        }

    }
}
