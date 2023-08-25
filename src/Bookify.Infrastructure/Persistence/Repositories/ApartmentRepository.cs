using Bookify.Domain.Apartments;
using Bookify.Domain.Users;

namespace Bookify.Infrastructure.Persistence.Repositories;

internal sealed class ApartmentRepository : Repository<Apartment>, IApartmentRepository
{
    public ApartmentRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}