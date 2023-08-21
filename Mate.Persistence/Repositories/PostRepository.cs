using System;
using Mate.Application.Repositories;
using Mate.Domain.Entities;
using Mate.Persistence.Context;

namespace Mate.Persistence.Repositories;

public class PostRepository : BaseRepository<Post>, IPostRepository
{
    private DataContext _db;
    public PostRepository(DataContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Post obj)
    {
        _db.Posts.Update(obj);

    }
}

