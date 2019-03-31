using System;
using Ducks_Strategy.ChangeRequest_RightApproach;

namespace Ducks_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial Requirement: 
            //Need to create a Duck Simulator (a game app) which will show two types of Ducks: Country Ducks and Wild Ducks.
            //All Ducks can swim and quack and Swim
            //Country Duck will have short leg and short nose
            //Wild Ducks has the long leg and long nose

            Console.WriteLine("Initial Requirement");
            var countryDuck = new InitialRequirement.CountryDuck();
            var wildDuck = new InitialRequirement.WildDuck();
            countryDuck.Display();
            Console.WriteLine("");
            wildDuck.Display();
            Console.WriteLine("");

            //ChangeRequest1:
            //Want to introduce two other type of Ducks
            //ElectricToyDuck - Can fly, it can make only Queek sound (not Quack) and has plastic leg and nose
            //WoodenToyDuck - Can't fly, Can't Quack, has wooden leg and nose
            //SomeWildDucks - Can fly
            Console.WriteLine("Change Request - Flaw in Design");
            var countryDuck1 = new ChangeRequest1Flaw.CountryDuck();
            var wildDuck1 = new ChangeRequest1Flaw.WildDuck();
            var electronicToyDuck = new ChangeRequest1Flaw.ElectronicToyDuck();
            var woodenToyDuck = new ChangeRequest1Flaw.WoodenToyDuck();
            countryDuck1.Display();
            Console.WriteLine("");
            wildDuck1.Display();
            Console.WriteLine("");
            electronicToyDuck.Display();
            Console.WriteLine("");
            woodenToyDuck.Display();
            Console.WriteLine("");

            //Lesson Learnt: Inheritance hasn't worked very well since the duck behaviour keep changing across the subclasses and its not appropriate that all subclasses to have those behaviours exposed. So the interface sounds promising. The flying ducks will implement Flyable interface and Quackable ducks will implement Quackable interface.

            //ChangeRequest2:
            //There are two type of Electric toys
            //SuperElectronicToyDuck - can fly without wings for couple of mins
            //RobotToyDuck - can fly with wings for long time.
            //We have variable fly behaviours. Wit the Flyable interface approach, each subclass has different implementaion of fly behaviour.
            //If any change in fly behaviour, we have to revist all flyable subclass. This will introduce the bugs.

            //Lesson Learnt: Interface will not bring the code reuse. And that means whenever you want to change the base fly behaviour, you need to revist all the flyable subclasses. This is nightmare.

            //Right Approch to Deal with: Take the variable behaviour of the entity and make then as separate class. And then pass the  behaviour class as dependency injection to th entity class.
            //So create the classes for your Entity (Duck) and variable Bhhaviours (Flyable, Quackable). The behaviours are passed as dependency to each different Duck sub class (CountryDuck, WildDuck, ElectronicDuck, RobotDuck, WoodenDuck)
            //In this approach, its each to change the behaviour without affecting other subclasses.
            //Each for TDD
            

            //ChangeRequest1:RightApproach
            Console.WriteLine("Change Request - Right Approach");
            var quackable = new Quackable();
            var countryDuck2 = new ChangeRequest_RightApproach.CountryDuck(quackable);
            var wildDuck2 = new ChangeRequest_RightApproach.WildDuck(quackable);
            var flyableWildDuck = new ChangeRequest_RightApproach.FlyableWildDuck(quackable, new FlyWithWings());
            var electronicToyDuck1 = new ChangeRequest_RightApproach.ElectronicDuck(new Queekable(), new FlyWithOutWings());

            countryDuck2.Display();
            Console.WriteLine("");
            wildDuck2.Display();
            Console.WriteLine("");
            flyableWildDuck.Display();
            Console.WriteLine("");
            electronicToyDuck1.Display();

        }
    }
}
