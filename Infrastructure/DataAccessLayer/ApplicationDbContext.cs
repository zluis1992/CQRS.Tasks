using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TaskItem> TaskItem => Set<TaskItem>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

    }

}
