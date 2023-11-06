using ObserverPattern.EventImplementation;
using ObserverPattern.TraditionalWay;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creater an observer on adharsystem which gets triggered on change of person
            var person = new Person("Shashi");
            var adharSystem = new AadharSystem(person);

            person.ChangeName("Sahil");

            //Traditional way of observers
            var watch = new Watch();
            var display = new DisplayObserver();
            var printer = new PrinterObserver();

            watch.Subscribe(display);
            watch.Subscribe(printer);

            watch.TimeCounter();
        }
    }
}