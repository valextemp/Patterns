using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat_01_00_Strategy
{
    abstract class Strategy
    {
        public abstract void Sort(ref int[] array);
    }
}
