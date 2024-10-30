using System;

namespace Kracks.Entities
{
    /// <summary>
    /// Лекарственный преппарат
    /// </summary>
    public class Kracks:BaseEntity
    {
        public string Name { get; set; }
        public string Manufacter { get; set; }
        public string CountryCodeId { get; set; }
    }
}
