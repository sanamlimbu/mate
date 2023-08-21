using Mate.Domain.Entities;

namespace Mate.Application.Repositories;

public interface ICommentRepository: IBaseRepository<Comment>
{
    void Update(Comment comment);
}

