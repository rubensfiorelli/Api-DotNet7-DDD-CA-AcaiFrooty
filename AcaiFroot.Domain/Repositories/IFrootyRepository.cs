using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Domain.Repositories
{
    public interface IFrootyRepository
    {
        Task<Product> AddAsync(Product product);

    }
}
