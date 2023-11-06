namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doorSystem = new TurnDoorFSM();

            doorSystem.Coin();
            doorSystem.Coin();
            doorSystem.Pass();
            doorSystem.Pass();
        }
    }
}