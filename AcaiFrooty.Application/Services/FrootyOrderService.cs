using AcaiFrooty.Application.Input.InputModels;
using AcaiFrooty.Application.Output.ViewModels;
using AcaiFrooty.Application.Services.Repositories;
using AcaiFrooty.Domain.Repositories;

namespace AcaiFrooty.Application.Services
{
    public class FrootyOrderService : IFrootyOrderService
    {
        protected readonly IFrootyOrderRepository _repository;

        public FrootyOrderService(IFrootyOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<FrootyOrderViewModel> AddAsync(AddFrootyOrderInputModel model)
        {
            var frootyOrder = model.ToEntity();
            var products = model
                .Products
                .Select(p => p.ToEntity())
                .ToList();

            frootyOrder.SetupOrder(products);

            await _repository.AddAsync(frootyOrder);
            await _repository.Commit();

            var converse = FrootyOrderViewModel.FromEntity(frootyOrder);

            return converse;
        }

        public async Task<bool> DeleteCategory(Guid categoryId)
        {
            var foodOrder = await _repository.DeleteCategory(categoryId);

            return foodOrder;
        }
    }
}
