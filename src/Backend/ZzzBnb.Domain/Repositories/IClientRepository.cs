using ZzzBnb.Domain.Entities;

namespace ZzzBnb.Domain.Repositories;

public interface IClientRepository : IRepository<Client>
{
    Task<bool> EmailExistsAsync(string email, CancellationToken ct = default);
}