using System.Collections.Generic;

namespace POSHero.Domain.Entities
{
    internal class Vendor
    {
        public List<Person> Representatives { get; set; }
        public Company Details { get; set; }
    }
}