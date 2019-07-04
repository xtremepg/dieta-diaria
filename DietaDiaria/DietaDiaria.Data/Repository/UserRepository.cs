using DietaDiaria.Domain.Users.Entities;
using DietaDiaria.Domain.Users.Interfaces;
using DietaDiaria.Generics.Repository;
using DietaDiaria.Infra.Data.Context;

namespace DietaDiaria.Infra.Data.Repository
{
    public class UserRepository : BaseRepository<long, User>, IUserRepository
    {
        private readonly DietaDiariaDbContext _context;

        public UserRepository(DietaDiariaDbContext context) : base(context)
        {
        }
    }
}
