namespace MediatorPattern
{
    internal class Person
    {
        private string Name;
        private ChatRoom Room;

        public Person(string name, ChatRoom room)
        {
            Name = name;
            Room = room;
        }

        public string GetName()
        {
            return Name;
        }
        public void PrivateMessage(Person sender, string message)
        {
            Console.WriteLine($"{sender.Name} sent you a message : {message}");
        }

        public void ReceiveMessage(Person sender, string message)
        {
            Console.WriteLine($"{sender.Name} sent you a message : {message}");
        }
    }
}