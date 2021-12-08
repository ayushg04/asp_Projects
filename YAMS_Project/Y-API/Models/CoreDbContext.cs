using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Y_API.Models
{
    public class CoreDbContext: System.Data.Entity.DbContext
    {
       
        public CoreDbContext()
            : base("name=UserDB")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public virtual System.Data.Entity.DbSet<UserTable> userTables { get; set; }  
        public virtual System.Data.Entity.DbSet<Register> Registers { get; set; }

        
    }
}
