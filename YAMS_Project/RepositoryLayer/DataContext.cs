using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAMS_Data.API;

namespace YAMS_Repository
{
    public class DataContext: DbContext
    {
        public DataContext()

        {
        }

        public DataContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<UserTable> usertables { get; set; }
    }
}
