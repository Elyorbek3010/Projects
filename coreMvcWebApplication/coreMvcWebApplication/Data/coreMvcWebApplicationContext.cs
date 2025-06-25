using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using coreMvcWebApplication.Models;

namespace coreMvcWebApplication.Data
{
    public class coreMvcWebApplicationContext : DbContext
    {
        public coreMvcWebApplicationContext (DbContextOptions<coreMvcWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<coreMvcWebApplication.Models.User> User { get; set; } = default!;
    }
}
