namespace RepositoryPatternAPI.Models
{
    public class Base
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime CreationDate { get; set; }
    }
}
