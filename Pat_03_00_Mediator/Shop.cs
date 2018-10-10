using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat_03_00_Mediator
{
    class Shop:Colleague    
    {
        public Shop(Mediator mediator)
            :base (mediator)
        { }

        public void SellKetchup(string message)
        {
            Console.WriteLine(this.GetType().Name +" sold "+ message);
        }
    }
}
