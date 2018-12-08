using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcAspCore.Models
{
    public class MvcAspCoreContext : DbContext
    {
        public MvcAspCoreContext (DbContextOptions<MvcAspCoreContext> options)
            : base(options)
        {
        }

        public DbSet<MvcAspCore.Models.Department> Department { get; set; }
    }
}
