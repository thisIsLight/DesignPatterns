using FactoryPattern.AbstractFactory;
using FactoryPattern.Factory;
using FactoryPattern.FactoryMethod;
using FactoryPattern.InnerFactory;
using FactoryPattern.ProblemScenarioOfPoint;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using a bad implementation of a instance creation
            var cartesian1 = new BadPoint(2, 2, "Caretesian");
            var polar1 = new BadPoint(2, 2, "Polar");
            Console.WriteLine("Cartesian :"+cartesian1.x+cartesian1.y);
            Console.WriteLine("Polar :"+polar1.x+polar1.y);

            //Using Factory Method
            var cartesian2 = FactoryMethodPoint.MakeCartiseanPoint(2, 2);
            var polar2 = FactoryMethodPoint.MakePolarPoint(2, 2);
            Console.WriteLine("Cartesian :" + cartesian2.x + cartesian2.y);
            Console.WriteLine("Polar :" + polar2.x + polar2.y);

            //Using Factory or Factory Classes
            var cartesian3 = PointFactory.CreateCartiseanPoint(2, 2);
            var polar3 = PointFactory.CreatePolarPoint(2, 2);
            Console.WriteLine("Cartesian :" + cartesian3.x + cartesian3.y);
            Console.WriteLine("Polar :" + polar3.x + polar3.y);

            //Using Inner Factory
            var cartesian4 = InnerFactoryPoint.Factory.CreateCartiseanPoint(2, 2);
            var polar4 = InnerFactoryPoint.Factory.CreatePolarPoint(2, 2);
            Console.WriteLine("Cartesian :" + cartesian4.x + cartesian4.y);
            Console.WriteLine("Polar :" + polar4.x + polar4.y);

            //Using Abstract Factory
            // How to use ? 
            //Create an object of the Hot beverage factory that you want
            //Pass it to the factory method
            //You will have your object in hand
            var teaFactory = new TeaFactory();
            var coffeeFactory = new CoffeeFactory();

            var tea = AbstractFactory.AbstractFactory.MakeHotDrink(teaFactory, "Chai");
            var coffee = AbstractFactory.AbstractFactory.MakeHotDrink(coffeeFactory, "Chai");

            tea.Consume();
            coffee.Consume();

        }
    }
}