namespace Filmovita.Entity
{
    public class Review
    {
        public int Id { get; set; }
        public string? Reviews { get; set; }
        public Movie Movie { get; set; }
    }
}
 