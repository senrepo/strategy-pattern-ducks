using System;

namespace Ducks_Strategy.InitialRequirement
{

    public interface IDuck
    {
         void Quack();
         void Swim();
         void Display();
    }

    public abstract class Duck : IDuck
    {
        public void Quack()
        {
           Console.Write("Quack.");
        }

        public void Swim()
        {
             Console.Write("Swim.");
        }

        public abstract void Display();
      
    }

    public class CountryDuck : Duck
    {
        public override void Display()
        {
            Console.Write("Country Duck Behaviours-");
            this.Quack();
            this.Swim();
            Console.Write($"Short Log and Short Nose.");
        }

    }

    public class WildDuck : Duck
    {
        public override void Display()
        {
            Console.Write("Wild Duck Behaviours-");
            this.Quack();
            this.Swim();
            Console.WriteLine("Long Leg and Long Nose.");
        }

    }    
}