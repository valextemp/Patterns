using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat_01_00_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var sort = new SelectionSort();
            var context = new Context(sort);
            context.Sort();
            context.PrintArray();

        }
    }
}
