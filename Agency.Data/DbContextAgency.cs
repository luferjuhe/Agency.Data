using Agency.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Agency.Data;
public class DbContextAgency : DbContext
{
    private readonly string connectionString;

    public DbContextAgency(DbContextOptions<DbContextAgency> options) : base(options)
    {

    }

    public DbContextAgency(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public DbSet<User> Users { get; set; }
}

