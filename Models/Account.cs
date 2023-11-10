namespace RepositoryPatternAPI.Models
{
    public class Account : Base
    {
        public int AccountNumber { get; set; }
        public Guid CustomerId { get; set; }
        public List<Card> Cards { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
