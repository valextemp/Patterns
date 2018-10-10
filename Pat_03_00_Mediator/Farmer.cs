using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat_03_00_Mediator
{
    class Farmer:Colleague
    {
        public Farmer(Mediator mediator)
            :base(mediator)
        { }

        public void GrowTomato()
        {
            string tomato = "Tomato";
            Console.WriteLine(this.GetType().Name+" raised "+tomato);
            mediator.Send(tomato, this);
        }
    }
}
