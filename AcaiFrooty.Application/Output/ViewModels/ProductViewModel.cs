using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Application.Output.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel(Guid id, string title, string description, double pricePerKg, double deliveryFee, Guid categoryId, DateTime createAt)
        {
            Id = id;
            Title = title;
            Description = description;
            PricePerKg = pricePerKg;
            DeliveryFee = deliveryFee;
            CategoryId = categoryId;
            CreateAt = createAt;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public double PricePerKg { get; private set; }
        public double DeliveryFee { get; private set; }
        public Guid CategoryId { get; private set; }
        public DateTime CreateAt { get; private set; }


        public static ProductViewModel FromEntity(Product entity)
        {
            return new ProductViewModel(
                entity.Id,
                entity.Title,
                entity.Description,
                entity.PricePerKg,
                entity.DeliveryFee,
                entity.CategoryId,
                entity.CreateAt
                );

        }



    }
}
