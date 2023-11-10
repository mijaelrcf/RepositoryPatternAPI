namespace RepositoryPatternAPI.Models
{
    public class Customer : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
