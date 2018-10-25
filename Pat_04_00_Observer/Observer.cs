using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat_04_00_Observer
{
    abstract class Observer
    {
        public abstract void Update(Subject theChangedSubject);
    }
}
