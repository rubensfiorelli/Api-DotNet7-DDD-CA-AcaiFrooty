using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Application.Input.InputModels
{
    public class ProductOrderItemsInputModel
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public ProductOrderItems ToEntity()
            => new ProductOrderItems(
                Title,
                Price
                );

    }
}
