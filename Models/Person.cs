using System.ComponentModel.DataAnnotations.Schema;

namespace EFcore.RelationShips.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<PhoneNumber> Phones { get; set; } = new List<PhoneNumber>(); // Collection navigation containing dependents

    }
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }

}
