using Mate.Domain.Entities;

namespace Mate.Application.Repositories;

public interface IMediaRepository: IBaseRepository<Media>
{
    void Update(Media media);
}

