using Microsoft.EntityFrameworkCore;
using RepositoryPatternAPI.Models;
using System.Collections.Generic;

namespace RepositoryPatternAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Guid customerId = Guid.NewGuid();

            List<Customer> customersInit = new List<Customer>();
            
            customersInit.Add(new Customer() 
            { 
                Id = customerId, 
                Name = "Mijael Callejas", 
                Email = "mijael.rcf@gmail", 
                Address = "Street 13" 
            });

            modelBuilder.Entity<Customer>(customer =>
            {
                customer.HasData(customersInit);
            });

            List<Account> accountsInit = new List<Account>();

            Guid accountId = Guid.NewGuid();
            Guid account2Id = Guid.NewGuid();

            accountsInit.Add(new Account() { Id = accountId, AccountNumber = 201000001, CreationDate = DateTime.Now });
            accountsInit.Add(new Account() { Id = account2Id, AccountNumber = 201000002, CreationDate = DateTime.Now });
            
            modelBuilder.Entity<Account>(account =>
            {
                account.HasData(accountsInit);
            });

            List<Card> cardsInit = new List<Card>();

            cardsInit.Add(new Card() { Id = Guid.NewGuid(), CardNumber = 700000001, AccountId = accountId });
            cardsInit.Add(new Card() { Id = Guid.NewGuid(), CardNumber = 700000002, AccountId = account2Id });

            modelBuilder.Entity<Card>(card =>
            {
                card.HasData(cardsInit);
            });

            List<Transaction> transactionsInit = new List<Transaction>();

            transactionsInit.Add(new Transaction() { Id = Guid.NewGuid(), Amount = 100, AccountId = accountId, TransactionDate = DateTime.Now, Type = 'D'});
            transactionsInit.Add(new Transaction() { Id = Guid.NewGuid(), Amount = 200, AccountId = accountId, TransactionDate = DateTime.Now, Type = 'C' });
            transactionsInit.Add(new Transaction() { Id = Guid.NewGuid(), Amount = 150, AccountId = account2Id, TransactionDate = DateTime.Now, Type = 'D' });
            transactionsInit.Add(new Transaction() { Id = Guid.NewGuid(), Amount = 350, AccountId = account2Id, TransactionDate = DateTime.Now, Type = 'C' });

            modelBuilder.Entity<Transaction>(transaction =>
            {
                transaction.HasData(transactionsInit);
            });
        }
    }
}
