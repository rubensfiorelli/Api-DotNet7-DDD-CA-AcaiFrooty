using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Application.Output.ViewModels
{
    public class ProductOrderItemsViewModel
    {
        public ProductOrderItemsViewModel(Guid id, string title, double price, DateTime createAt)
        {
            Id = id;
            Title = title;
            Price = price;
            CreateAt = createAt;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public double Price { get; private set; }
        public DateTime CreateAt { get; private set; }


        public static ProductOrderItemsViewModel FromEntity(ProductOrderItems entity)
        {
            return new ProductOrderItemsViewModel(
                entity.Id,
                entity.Title,
                entity.Price,
                entity.CreateAt
                );
        }
    }
}
