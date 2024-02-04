using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBank.Microservice.Domain.Entities
{
    public class AbsaBankDbContext : DbContext
    {
        //public DbSet<AccountNumbers>BankAccounts { get; set; }	
        public DbSet<StudentAccount> StudentAccounts { get; set; }
        //public DbSet<StudentAccountStatus> StudentAccountStatus { get; set; }	
        //public DbSet<MoneyTransfer>MoneyTransfer{ get; set; }	
        //public DbSet<TransactionStatus> TransactionStatus { get; set; }


        public AbsaBankDbContext(DbContextOptions<AbsaBankDbContext> options) :base(options)
        {
            try
            {
                var dbCreator = Database.GetService<IDatabaseCreator>()
                    as RelationalDatabaseCreator;
                if (dbCreator != null)
                {
                    if (!dbCreator.CanConnect()) dbCreator.Create();
                    if (!dbCreator.HasTables()) dbCreator.CreateTables();
                }
            }
            catch (Exception)
            {


                throw;
            }

        }

    }
}
