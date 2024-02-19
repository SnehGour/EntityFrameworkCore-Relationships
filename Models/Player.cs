namespace EFCore.RelationShips.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public PlayerType PlayerType { get; set; }
    }

    public enum PlayerType
    {
        Batsman,
        Bowler,
        Allrounder
    }

}
