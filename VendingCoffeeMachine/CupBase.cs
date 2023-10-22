using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingCoffeeMachine
{
    public abstract class CupBase
    {
        public CupBase() 
        { 
        }

        internal void Stir()
        {
            Console.WriteLine("The components in the cup are stirring");
        }
    }
}
