namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mediator is a pattern which lets communication through between two or components without them knowing each other
            //We are going to build a chatroom
            var room = new ChatRoom();

            var person1 = new Person("Panda", room);
            var person2 = new Person("Kunda Baba", room);
            var person3 = new Person("Huha hui", room);

            room.Add(person1);
            room.Add(person2);
            room.Add(person3);

            //Person A sends a message to person B
            room.Message(person1, person2, "You are Kunda");

            //Person 1 sends message to everyone
            room.BroadCast(person1, "I am Panda number 1");
        }
    }
}