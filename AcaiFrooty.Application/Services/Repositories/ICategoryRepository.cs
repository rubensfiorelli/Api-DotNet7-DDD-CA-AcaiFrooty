using AcaiFrooty.Application.Output.ViewModels;

namespace AcaiFrooty.Application.Services.Repositories
{
    public interface ICategoryRepository
    {
        Task<CategoryViewModel> GetAllCategories();
    }
}
