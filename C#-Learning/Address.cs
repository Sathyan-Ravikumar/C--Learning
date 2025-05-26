using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning
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
