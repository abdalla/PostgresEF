using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Postgres_EF.EF.Entities;

namespace Postgres_EF.EF
{

    public class DBContext : DbContext
    {
        public DBContext() : base(nameOrConnectionString: "MonkeyFist") { }
        public DbSet<Pet> Pets { get; set; }
    }

}
