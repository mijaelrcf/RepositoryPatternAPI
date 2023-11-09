namespace RepositoryPatternAPI.Models
{
    public class Transaction : Base
    {
        public char Type { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
    }
}
