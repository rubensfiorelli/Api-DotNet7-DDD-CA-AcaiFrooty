using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Domain.Repositories
{
    public interface IFrootyOrderRepository : IUnitOfWork
    {
        Task<FrootyOrder> AddAsync(FrootyOrder frootyOrder);
        Task<bool> DeleteCategory(Guid id);

    }
}
