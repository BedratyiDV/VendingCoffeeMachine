using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingCoffeeMachine
{
    internal class Cup : CupBase, IAddCoffee, IAddMilk, IAddSugar, IAddWater
    {
        public void AddCoffee()
        {
            Console.WriteLine("Currently adding coffee into the cup");
        }
        public void AddMilk()
        {
            Console.WriteLine("Currently adding milk into the cup");
        }
        public void AddSugar()
        {
            Console.WriteLine("Currently adding sugar into the cup");
        }
        public void AddWater()
        {
            Console.WriteLine("Currently adding water into the cup");
        }
    }
}
