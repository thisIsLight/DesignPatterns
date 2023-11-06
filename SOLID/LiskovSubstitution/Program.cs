namespace LiskovSubstitution
{
    public class Program
    {
        static void Main(string[] args)
        {
            //This principle says that on upcasting, the behavior of the object shouldn't change
            //The properties in the parent should be reflecting fine for the child
            //Every sub class should be able to reflect a super class

            //A square when denoted as a Rectangle should behave like a square and not rectangle
            var rectangle = new Rectangle(2, 3);
            Console.WriteLine("Area of reactagle with 2 and 3 is "+rectangle.Area());

            var square = new Square();
            square.Width = 2;
            Console.WriteLine("Area of square with 2 is "+square.Area());

            Rectangle upcastedSquare = new Square();
            upcastedSquare.Width = 3;
            // The above line creates a problem because the values are only denoted to recatangle


            Console.WriteLine("Area of square with 3 is "+upcastedSquare.Area());
        }
    }
}