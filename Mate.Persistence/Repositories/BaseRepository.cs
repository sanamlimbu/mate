using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Mate.Application.Repositories;
using Mate.Persistence.Context;
using Mate.Domain.Common;

namespace Mate.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private readonly DataContext _db;
    internal DbSet<T> dbSet;

    public BaseRepository(DataContext db)
    {
        _db = db;
        this.dbSet = _db.Set<T>();

    }
    public void Add(T entity)
    {
        dbSet.Add(entity);
    }

    // includeProperties should be comma seperated like "Post,User"
    public async Task<T?> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, CancellationToken cancellationToken = default)
    {
        IQueryable<T> query = dbSet;
        query = query.Where(filter);
        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var includeProp in includeProperties
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }
        return await query.FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, CancellationToken cancellationToken = default)
    {
        IQueryable<T> query = dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var includeProp in includeProperties
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }
        return await query.ToListAsync(cancellationToken);
    }

    public void Remove(T entity)
    {
        entity.DeletedAt = DateTime.UtcNow;
        dbSet.Update(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        foreach (var entity in entities)
        {
            entity.DeletedAt = DateTime.UtcNow;
            dbSet.Update(entity);
        }
    }
}

