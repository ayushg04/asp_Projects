using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using YAMS_Data.API;

namespace YAMS_Repository
{
    public class CoreDbContext: IdentityDbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions options)
            : base(options)
        {
        }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }*/
        public virtual Microsoft.EntityFrameworkCore.DbSet<UserTable> userTables { get; set; }  
        public virtual Microsoft.EntityFrameworkCore.DbSet<Register> Registers { get; set; }

        
    }
}
