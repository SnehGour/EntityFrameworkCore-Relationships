using System.Text.Json.Serialization;

namespace EFcore.RelationShips.Models.Dto
{
    public class PhoneNumberDto
    {
        public int PhoneNumberId { get; set; }
        public string Phone { get; set; }
        public int PersonId { get; set; } // since it is int and can't be null it is required FK property
    }

    public class PhoneResponseNumberDto
    {
        public int PhoneNumberId { get; set; }
        public string Phone { get; set; }
        public int PersonId { get; set; } // since it is int and can't be null it is required FK property
    }
}
