using AcaiFrooty.Application.Input.InputModels;
using AcaiFrooty.Application.Output.ViewModels;

namespace AcaiFrooty.Application.Services.Repositories
{
    public interface IProductService
    {
        Task<ProductViewModel> AddAsync(ProductInputModel model);

    }
}
