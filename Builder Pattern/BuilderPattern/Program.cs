using BuilderPattern.BasicBuilderPattern;
using BuilderPattern.OldPattern;
using BuilderPattern.StepWiseBuilderPattern;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Builder pattern is a Creational Pattern
            //Used when we are trying to create a complex object
            //By complex we mean, any object that has few dependencies/steps to be followed/chained initializations

            //Without buiilder pattern, we create a class and create alot of constructors for various opertaions
            //Or we create a single constructor that takes a lot of inputs as parameters

            PersonClass p = new PersonClass("Kunal", 22, "Ziffy");
            Console.WriteLine(p.ToString());

            //Basic Fluent Builder Pattern
            //Allows chained calls
            BasicPersonBuilder basicPersonBuilder = new BasicPersonBuilder();
            basicPersonBuilder.Named("Kunal").WorksAt("Ziffy").WorksAs("Engineer").Earns(234);
            Console.WriteLine(basicPersonBuilder.ToString());

            //Building an object on conditions
            //If a car is Sedan, it can have only certain wheel type
            var stepWiseBuilder = new CarBuilder();
            stepWiseBuilder.Build().AddName("Sedan").AddWheels(24);
            Console.WriteLine(stepWiseBuilder.ToString());

            //Facet Builder
            var facet = new FacetPersonBuilder();
            facet.Works.WorksAt("Ziffy").WorksAs("Engineer").Earns(123)
                .Lives.AddAddress1("Line 1").AddAddress2("Line 2").AddZipCode(123345);
            Console.WriteLine(facet);
        }
    }
}