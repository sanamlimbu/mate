
using Mate.Application.Repositories;
using Mate.Domain.Entities;
using Mate.Persistence.Context;

namespace Mate.Persistence.Repositories;

public class CommentRepository : BaseRepository<Comment>, ICommentRepository
{
    private DataContext _db;
    public CommentRepository(DataContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Comment obj)
    {
        _db.Comments.Update(obj);

    }
}

