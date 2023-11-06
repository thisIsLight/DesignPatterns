namespace PrototypePattern.CustomInterfaceObjectClone
{
    public class CustomInterfacePerson : IDeepCloneable<CustomInterfacePerson>
    {
        public string Name;
        public CustomInterfaceAddress Address;

        public CustomInterfacePerson(string name, CustomInterfaceAddress address)
        {
            Name = name;
            Address = address;
        }

        public CustomInterfacePerson Clone()
        {
            return new CustomInterfacePerson(Name, Address.Clone());
        }
    }
}