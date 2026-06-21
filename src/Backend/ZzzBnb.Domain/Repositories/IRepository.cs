using ZzzBnb.Domain.Entities;

namespace ZzzBnb.Domain.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    Task AddAsync(T entity, CancellationToken ct = default);
}