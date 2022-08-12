using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdventureWorksDB.Models;

namespace AdventureWorksDB.Data
{
    public class AdventureWorksDBContext : DbContext
    {
        public AdventureWorksDBContext (DbContextOptions<AdventureWorksDBContext> options)
            : base(options)
        {
        }

        public DbSet<AdventureWorksDB.Models.Customer> Customer { get; set; } 
        public DbSet<AdventureWorksDB.Models.Address> Address { get; set; } 

    }
}
