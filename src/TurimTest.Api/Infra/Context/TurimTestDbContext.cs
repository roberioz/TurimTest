using Microsoft.EntityFrameworkCore;

namespace TurimTest.Api.Infra.Context;

public class TurimTestDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "TurimTest");
    }
}
