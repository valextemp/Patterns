using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat_01_00_Strategy
{
    class Context
    {
        Strategy strategy;
        int[] array = { 3, 5, 1, 2, 4 };

        public Context(Strategy strategyvalue) => strategy = strategyvalue;

        public void Sort()
        {
            strategy.Sort(ref array);
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }

    }
}
