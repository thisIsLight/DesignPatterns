namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a car with age limitation
            var carWithUnderAge = new CarProxyWithAgeLimitation("Maruti 800", 17);
            var carWithOverAge = new CarProxyWithAgeLimitation("Maruti 800", 27);

            carWithUnderAge.Drive();
            carWithOverAge.Drive();
        }
    }
}