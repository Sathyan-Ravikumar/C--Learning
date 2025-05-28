namespace C__Learning.Value_Reference_Type_and_Generic_Collections
{
    public struct Address
    {
        public string City { get; set; }
        public string State { get; set; }

        public Address(string city, string state)
        {
            City = city;
            State = state;
        }
    }
}