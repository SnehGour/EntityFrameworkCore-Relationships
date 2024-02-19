using System.Text.Json.Serialization;

namespace EFcore.RelationShips.Models
{
    public class PhoneNumber
    {
        public int PhoneNumberId { get; set; }
        public string Phone { get; set; }
        public int PersonId { get; set; } // since it is int and can't be null it is required FK property
        [JsonIgnore]
        public Person Person { get; set; } = null!;
    }

}
