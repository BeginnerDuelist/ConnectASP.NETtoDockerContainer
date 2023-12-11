using ConnectASP.NETtoDockerContainer;
using Microsoft.EntityFrameworkCore;

public class ApiDbContext:DbContext
{
     public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }
     public DbSet<Student>   Students { get; set; }

}