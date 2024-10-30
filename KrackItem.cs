using System;
using System.Collections.Generic;
using System.Text;

namespace Kracks.Entities
{
    public class KrackItem:BaseEntity
    {
        public Guid KrackId { get; set; }
        public Guid KrackStoreId { get; set; }
        public decimal Cost { get; set; }
        public int Count { get; set; }
    }
}
