using Kindergarten.Application.Abstractions;
using Kindergarten.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kindergarten.Infrastructure.Persistance;

public class KindergartenDbContext : DbContext, IApplicationDbContext
{
    public KindergartenDbContext(DbContextOptions<KindergartenDbContext> options)
        : base(options)
    {
        Database.Migrate();
    }
    public DbSet<Child> Children { get; set; }
    public DbSet<Educator> Educators { get; set; }
    public DbSet<Guardian> Guardians { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    async ValueTask<int> IApplicationDbContext.SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await SaveChangesAsync(cancellationToken);
    }
}