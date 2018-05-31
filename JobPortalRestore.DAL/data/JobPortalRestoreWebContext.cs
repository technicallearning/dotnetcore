using JobPortalRestore.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace JobPortalRestore.DAL.data
{
    public class JobPortalRestoreWebContext: DbContext
    {
        public JobPortalRestoreWebContext(DbContextOptions<JobPortalRestoreWebContext> options)
            :base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
