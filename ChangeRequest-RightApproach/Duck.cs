using System;

namespace Ducks_Strategy.ChangeRequest_RightApproach
{

    //Interface for Entity and has only common methods for the all subclass entities
    public interface IDuck
    {
        void Swim();
        void Display();
    }

    //Create Interface each vaiable Behaviours
    public interface IFlyable
    {
        void Fly();
    }

    public interface IQuackable
    {
        void Quack();
    }

    public abstract class Duck : IDuck
    {
        public abstract void Display();

        public void Swim()
        {
            Console.Write("Swim.");
        }
    }

    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.Write("Fly With Wings.");
        }
    }

    public class FlyWithWingsLongTime : IFlyable
    {
        public void Fly()
        {
            Console.Write("Fly With Wings long time.");
        }
    }


    public class FlyWithOutWings : IFlyable
    {
        public void Fly()
        {
            Console.Write("Fly Without Wings.");
        }
    }

    public class Quackable : IQuackable
    {
        public void Quack()
        {
            Console.Write("Quack.");
        }
    }

    public class Queekable : IQuackable
    {
        public void Quack()
        {
            Console.Write("Queek.");
        }
    }

    public class CountryDuck : Duck
    {
        private IQuackable quackable;
        public CountryDuck(IQuackable quackable)
        {
            this.quackable = quackable;
        }
        public override void Display()
        {
            Console.Write("Country Duck Behaviours-");
            quackable.Quack();
            this.Swim();
            Console.Write($"Short Log and Short Nose.");
        }
    }

    public class WildDuck : Duck
    {
        private IQuackable quackable;
        public WildDuck(IQuackable quackable)
        {
            this.quackable = quackable;
        }
        public override void Display()
        {
            Console.Write("Wild Duck Behaviours-");
            quackable.Quack();
            this.Swim();
            Console.Write($"Long Leg and Long Nose.");
        }

    }

    public class FlyableWildDuck : WildDuck
    {
        private IFlyable flyable;
        private IQuackable quackable;

        public FlyableWildDuck(IQuackable quackable, IFlyable flyable) : base(quackable)
        {
            this.flyable = flyable;
            this.quackable = quackable;
        }

        public override void Display()
        {
            Console.Write("Flyable WildDuck Behaviours-");
            quackable.Quack();
            flyable.Fly();
            this.Swim();
            Console.Write($"Long Leg and Long Nose.");
        }
    }

    public class ElectronicDuck : Duck
    {
        private IQuackable quackable;
        private IFlyable flyable;
        public ElectronicDuck(IQuackable quackable, IFlyable flyable)
        {
            this.quackable = quackable;
            this.flyable = flyable;

        }
        public override void Display()
        {
            Console.Write("Electronic Duck Behaviours-");
            quackable.Quack();
            flyable.Fly();
            this.Swim();
            Console.Write($"Plastic Leg and Plastic Nose.");
        }
    }

     public class RobotDuck : Duck
    {
        private IQuackable quackable;
        private IFlyable flyable;
        public RobotDuck(IQuackable quackable, IFlyable flyable)
        {
            this.quackable = quackable;
            this.flyable = flyable;

        }
        public override void Display()
        {
            Console.Write("Electronic Duck Behaviours-");
            quackable.Quack();
            flyable.Fly();
            this.Swim();
            Console.Write($"Plastic Leg and Plastic Nose.");
        }
    }  
}