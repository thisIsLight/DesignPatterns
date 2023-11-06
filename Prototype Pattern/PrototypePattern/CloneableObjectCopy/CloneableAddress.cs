namespace PrototypePattern.CloneableObjectCopy
{
    public class CloneableAddress : ICloneable
    {
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }

        public CloneableAddress(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public object Clone()
        {
            return new CloneableAddress(StreetName, HouseNumber);
        }
    }
}