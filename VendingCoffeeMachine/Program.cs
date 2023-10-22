namespace VendingCoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void AddCoffee(IAddCoffee cup)
            {
                cup.AddCoffee();
            }

            void AddSugar(IAddSugar cup)
            {
                cup.AddSugar();
            }

            void AddWater (IAddWater cup) 
            { 
                cup.AddWater();
            }

            void AddMilk(IAddMilk cup)
            {
                cup.AddMilk();
            }

            Cup cupOfCoffee = new Cup();

            AddCoffee(cupOfCoffee);
            //cupOfCoffee.Stir();

            AddSugar(cupOfCoffee);
            cupOfCoffee.Stir();

            AddWater (cupOfCoffee);
            cupOfCoffee.Stir();

            AddMilk (cupOfCoffee);
            cupOfCoffee.Stir();
        }
    }
}