namespace Mate.Application.Repositories;

public interface IUnitOfWork
{
    IUserRepository User { get; }
    IPostRepository Post { get; }
    ICommentRepository Comment { get; }
    IReplyRepository Reply { get; }
    IMediaRepository Media { get; }
    Task Save(CancellationToken cancellationToken);
}

