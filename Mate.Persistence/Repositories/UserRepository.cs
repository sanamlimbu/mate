using Mate.Application.Repositories;
using Mate.Domain.Entities;
using Mate.Persistence.Context;

namespace Mate.Persistence.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    private DataContext _db;
    public UserRepository(DataContext db) : base(db)
    {
        _db = db;
    }

    public void Update(User obj)
    {
        _db.Users.Update(obj);

    }
}

