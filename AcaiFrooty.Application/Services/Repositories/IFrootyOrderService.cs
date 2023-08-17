using AcaiFrooty.Application.Input.InputModels;
using AcaiFrooty.Application.Output.ViewModels;

namespace AcaiFrooty.Application.Services.Repositories
{
    public interface IFrootyOrderService
    {
        Task<FrootyOrderViewModel> AddAsync(AddFrootyOrderInputModel model);
        Task<bool> DeleteCategory(Guid categoryId);

    }
}
