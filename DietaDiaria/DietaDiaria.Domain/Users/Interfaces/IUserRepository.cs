using DietaDiaria.Generics.Interfaces;
using DietaDiaria.Domain.Users.Entities;

namespace DietaDiaria.Domain.Users.Interfaces
{
    public interface IUserRepository : IBaseRepository<long, User>
    {
    }
}
