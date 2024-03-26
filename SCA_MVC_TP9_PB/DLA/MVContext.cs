using Microsoft.EntityFrameworkCore;
using SCA_MVC_TP9_PB.Models;

namespace SCA_MVC_TP9_PB.DLA;
public class MVContext : DbContext
{
    public DbSet<Professor> professors { get; set; }

    public MVContext(DbContextOptions<MVContext> options) : base(options)
    {

    }

}

