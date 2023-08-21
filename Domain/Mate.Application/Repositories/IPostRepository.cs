using Mate.Domain.Entities;

namespace Mate.Application.Repositories;

public interface IPostRepository: IBaseRepository<Post>
{
	void Update(Post post);
}

