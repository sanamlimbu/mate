using Mate.Domain.Entities;

namespace Mate.Application.Repositories;

public interface IUserRepository: IBaseRepository<User>
{
    void Update(User user);
}

