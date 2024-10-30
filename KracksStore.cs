using System;
using System.Collections.Generic;
using System.Text;
using Kracks.ValueObjects;

namespace Kracks.Entities
{
    public class KracksStore:BaseEntity
    {
        public string KrackNetwork { get; set; }
        public Address address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
