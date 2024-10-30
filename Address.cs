using System;
using System.Collections.Generic;
using System.Text;

namespace Kracks.ValueObjects
{
    public class Address
    {
        public Address(string city,string street,string house)
        {
            City = city;
            Street = street;
            House = house;
        }
        public string Street { get; set; }
        public string City { get; set; }
        public string House { get; set; }
    }
}
