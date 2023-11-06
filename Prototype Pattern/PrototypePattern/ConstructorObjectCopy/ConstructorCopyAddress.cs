namespace PrototypePattern.ConstructorObjectCopy
{
    internal class ConstructorCopyAddress
    {
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }

        public ConstructorCopyAddress(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public ConstructorCopyAddress(ConstructorCopyAddress other)
        {
            StreetName = other.StreetName;
            HouseNumber = other.HouseNumber;
        }
    }
}