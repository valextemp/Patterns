using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat_02_00_Template_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var flag = new UkraineFlag();
            flag.Draw();
            Console.WriteLine();
            Console.WriteLine();
            var flag1 = new PolandFlag();
            flag1.Draw();

            Console.ReadLine();
        }
    }
}
