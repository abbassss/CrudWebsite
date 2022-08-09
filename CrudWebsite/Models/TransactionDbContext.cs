using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWebsite.Models
{
    public class TransactionDbContext:DbContext
    {
        public DbSet<Transaction> transactions { get; set; }

        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        {

        }
    }
}
