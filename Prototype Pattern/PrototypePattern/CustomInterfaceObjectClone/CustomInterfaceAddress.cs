namespace PrototypePattern.CustomInterfaceObjectClone
{
    public class CustomInterfaceAddress : IDeepCloneable<CustomInterfaceAddress>
    {
        public string StreetName;
        public int HouseNumber;

        public CustomInterfaceAddress(string streetAddress, int houseNumber)
        {
            StreetName = streetAddress;
            HouseNumber = houseNumber;
        }

        public CustomInterfaceAddress Clone()
        {
            return new CustomInterfaceAddress(StreetName, HouseNumber);
        }
    }
}