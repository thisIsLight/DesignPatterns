namespace PrototypePattern.ConstructorObjectCopy
{
    internal class ConstructorCopyPerson
    {
        public string Name;
        public ConstructorCopyAddress Address;

        public ConstructorCopyPerson(string name, ConstructorCopyAddress address)
        {
            Name = name;
            Address = address;
        }
        public ConstructorCopyPerson(ConstructorCopyPerson other)
        {
            Name = other.Name;
            Address = new ConstructorCopyAddress(other.Address);
        }
    }
}