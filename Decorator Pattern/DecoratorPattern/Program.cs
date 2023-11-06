namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basically a decorator is a IS a and a HAS a object

            //Lets say we want a coffe with milk and sugar
            var coffee = new Coffee(10);
            var sugarInCoffee = new Sugar(2, coffee);
            var milkInSugarCoffee = new Milk(2, sugarInCoffee);

            Console.WriteLine($"Your total cost is : {milkInSugarCoffee.Cost()}");
        }
    }
}