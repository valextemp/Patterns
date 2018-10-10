using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat_03_00_Mediator
{
    class Cannery : Colleague
    {
        public Cannery(Mediator mediator)
            : base(mediator)
        {}
        public void MakeKetchup(string message)
        {
            string ketchup = message + "Ketchup";
            Console.WriteLine(this.GetType().Name+" produced "+ketchup );
            mediator.Send(ketchup, this);
        }
    }
}
