namespace RepositoryPatternAPI.Models
{
    public class Card : Base
    {
        public int CardNumber { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
    }
}
