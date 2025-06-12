using Kindergarten.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kindergarten.Application.Abstractions;
public interface IApplicationDbContext
{
    DbSet<Child> Children { get; set; }
    DbSet<Guardian> Guardians { get; set; }
    DbSet<Educator> Educators { get; set; }
    ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken = default!);
}
