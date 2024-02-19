namespace EFcore.RelationShips.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();  // Collection navigation to dependent
    } 

    // Dependent (Child)
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BlogId { get; set; } // Required FK property
        public Blog Blog { get; set; } // Navigation to Principal

    }
}
