namespace EFcore.RelationShips.Models.Dto
{
    public class PersonDto
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class PersonResponseDto
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<PhoneNumber> PhoneNumberList { get; set; }
    }
}
