namespace C__Learning.Value_Reference_Type_and_Generic_Collections
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address HomeAddress { get; set; }
        public StudentStatus Status { get; set; }
        public HashSet<string> Skills { get; set; } = new HashSet<string>();

        public override string ToString()
        {
            return $"{Id} - {Name}, {HomeAddress.City}, {Status}";
        }
    }
}