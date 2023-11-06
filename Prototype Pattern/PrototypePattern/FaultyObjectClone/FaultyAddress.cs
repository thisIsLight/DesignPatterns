namespace PrototypePattern.FaultyObjectClone
{
    [Serializable]
    public class FaultyAddress
    {
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }

        public FaultyAddress(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }
    }
}