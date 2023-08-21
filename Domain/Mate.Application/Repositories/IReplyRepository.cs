using Mate.Domain.Entities;

namespace Mate.Application.Repositories;

public interface IReplyRepository : IBaseRepository<Reply>
{
    void Update(Reply reply);
}
