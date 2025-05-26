using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address HomeAddress { get; set; }
        public StudentStatus Status { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name}, {HomeAddress.City}, {Status}";
        }
    }
}
