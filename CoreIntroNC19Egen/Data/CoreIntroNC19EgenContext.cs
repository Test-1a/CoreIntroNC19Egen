using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreIntroNC19Egen.Models
{
    public class CoreIntroNC19EgenContext : DbContext
    {
        public CoreIntroNC19EgenContext (DbContextOptions<CoreIntroNC19EgenContext> options)
            : base(options)
        {
        }

        public DbSet<CoreIntroNC19Egen.Models.Person> Person { get; set; }
    }
}
