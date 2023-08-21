
using Mate.Application.Repositories;
using Mate.Domain.Entities;
using Mate.Persistence.Context;

namespace Mate.Persistence.Repositories;

public class ReplyRepository : BaseRepository<Reply>, IReplyRepository
{
    private DataContext _db;
    public ReplyRepository(DataContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Reply obj)
    {
        _db.Replies.Update(obj);

    }
}

