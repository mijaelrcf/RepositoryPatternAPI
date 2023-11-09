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
    }
}
