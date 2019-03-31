using System;

namespace Ducks_Strategy.ChangeRequest1Flaw
{
    public interface IDuck
    {
        void Quack();
        void Swim();
        void Fly();
        void Display();
    }

    public abstract class Duck : IDuck
    {
        public virtual void Quack()
        {
            Console.Write("Quack.");
        }

        public void Swim()
        {
            Console.Write("Swim.");
        }

        public virtual void Fly()
        {
            Console.Write("Fly.");
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
            //this.Fly(); //flaw in the design because Country ducks are NOT flyable. Code misuse risk introduced because of override
            Console.Write($"Short Log and Short Nose.");
        }

        public override void Fly()
        {
            Console.Write(""); //remove the fly behaviour
        }

    }

    public class WildDuck : Duck
    {
        public override void Display()
        {
            Console.Write("Wild Duck Behaviours-");
            this.Quack();
            this.Swim();
            this.Fly(); //flaw in the design because not all wild ducks are flyable. Code misuse risk introduced
            Console.Write("Long Leg and Long Nose.");
        }

    }
    public class ElectronicToyDuck : Duck
    {
        public override void Display()
        {
            Console.Write("Electric Toy Duck Behaviours-");
            this.Quack();
            this.Swim();
            this.Fly();
            Console.Write("Plastic Leg and Nose.");
        }

        public override void Quack()
        {
            Console.Write("Queek.");
        }
    }

    public class WoodenToyDuck : Duck
    {
        public override void Display()
        {
            Console.Write("Wooden Toy Duck Behaviours-");
            //this.Quack();  //flaw in the design. Code misuse risk introduced beause of the override behaviour
            this.Swim();
            //this.Fly();  //flaw in the design. Code misuse risk introduced beause of the override behaviour
            Console.Write("Wooden Leg and Wooden Nose.");
        }
        public override void Quack()
        {
            Console.Write(""); //remove the sound making behaviour
        }
            public override void Fly()
        {
            Console.Write(""); //remove the fly behaviour
        }    
    }
}