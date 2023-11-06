using OpenClosed.NewFilterApproach;
using static OpenClosed.Constants;

namespace OpenClosed
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Requirement
            //We want to create a product class and then a filter for those products which can be filtered on one or more than one criteria
            //Make old and new both ways
            //One which has Open-closed breaking and one which is not breaking the open closed principle

            //Creating Products
            var apple = new Product("Apple", Color.Red, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Medium);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            //Calling older method which was modified again and again
            foreach(var product in OldFIlter.FilterProductByColor(products, Color.Green))
            {
                Console.WriteLine(product);
            }
            foreach (var product in OldFIlter.FilterProductBySize(products, Size.Medium))
            {
                Console.WriteLine(product);
            }

            //Calling the Open=closed compliant code
            //This requires usage of interfaces
            //We create a set of interfaces and implement those interfaces for filtering
            //Hence, for every new type of filter, we don't modify the interface, instead we just add a new class that implements the interface
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Filtered using New Approach");

            var sizeSpecification = new SizeSpecification(Size.Medium);
            var filter = new FIlterBySize();
            foreach(var p in filter.Filter(products, sizeSpecification))
            {
                Console.WriteLine(p.ToString());
            }

            var colorSpecification = new ColorSpecification(Color.Red);
            foreach (var p in filter.Filter(products, colorSpecification))
            {
                Console.WriteLine(p.ToString());
            }

            var combinedSpecification = new SizeAndColorSpecification(Size.Large, Color.Blue);
            foreach (var p in filter.Filter(products, combinedSpecification))
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}