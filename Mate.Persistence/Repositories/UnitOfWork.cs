using Mate.Application.Repositories;
using Mate.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Mate.Persistence.Repositories;

public class UnitOfWork: IUnitOfWork
{
    private DataContext _db;
    public IUserRepository User { get; private set; }
    public IPostRepository Post { get; private set; }
    public ICommentRepository Comment { get; private set; }
    public IReplyRepository Reply { get; private set; }
    public IMediaRepository Media { get; private set; }

    public UnitOfWork(DataContext db)
	{
        _db = db;
        User = new UserRepository(_db);
        Post = new PostRepository(_db);
        Comment = new CommentRepository(_db);
        Reply = new ReplyRepository(_db);
        Media = new MediaRepository(_db);
    }
   
    public Task Save(CancellationToken cancellationToken)
    {
        return _db.SaveChangesAsync(cancellationToken);
    }
}

