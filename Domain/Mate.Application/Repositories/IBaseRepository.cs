using System.Linq.Expressions;
using Mate.Domain.Common;

namespace Mate.Application.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, CancellationToken cancellationToken = default);
        Task<T?> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, CancellationToken cancellationToken = default);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}

