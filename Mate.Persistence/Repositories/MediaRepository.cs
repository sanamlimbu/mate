using Mate.Application.Repositories;
using Mate.Domain.Entities;
using Mate.Persistence.Context;

namespace Mate.Persistence.Repositories;

public class MediaRepository : BaseRepository<Media>, IMediaRepository
{
    private DataContext _db;
    public MediaRepository(DataContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Media obj)
    {
        _db.Media.Update(obj);

    }
}

