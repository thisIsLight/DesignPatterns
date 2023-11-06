using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MediatorPattern
{
    internal class ChatRoom
    {
        private List<Person> People = new List<Person>(); 
        public void Add(Person person)
        {
            People.Add(person);
        }

        public void Message(Person sender, Person receiver, string message)
        {
            People.FirstOrDefault(x => x.GetName() == receiver.GetName()).PrivateMessage(sender, message);
        }

        public void BroadCast(Person sender, string message)
        {
            People.ForEach(x => x.ReceiveMessage(sender, message));
        }
    }
}