using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> AddAsync(Category category);

    }
}
