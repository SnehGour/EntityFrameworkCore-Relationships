namespace Test.EFcore.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string  Caption { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
