using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JobPortalRestore.Web.Models
{
    public class JobPortalRestoreWebContext : DbContext
    {
        public JobPortalRestoreWebContext (DbContextOptions<JobPortalRestoreWebContext> options)
            : base(options)
        {
        }

        public DbSet<JobPortalRestore.Web.Models.Movie> Movie { get; set; }
    }
}
