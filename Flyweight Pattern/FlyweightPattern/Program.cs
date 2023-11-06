namespace FlyweightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basically we need not store the full information in rental Class
            var movie1 = new Movie();
            var movie2 = new Movie();

            var rentalStore = new Rental();
            rentalStore.movies.Add(movie1);
            rentalStore.movies.Add(movie2);
        }
    }
}