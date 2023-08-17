using AcaiFrooty.Application.Output.ViewModels;

namespace AcaiFrooty.Application.Output.Repositories
{
    public interface ICategoryRepository
    {
        Task<CategoryViewModel> GetAllCategories();
    }
}
