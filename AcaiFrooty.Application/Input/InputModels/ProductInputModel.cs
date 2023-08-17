using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Application.Input.InputModels
{
    public class ProductInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double PricePerKg { get; set; }
        public double DeliveryFee { get; set; }
        public Guid CategoryId { get; set; }


        public Product ToEntity()
            => new Product(
                Title,
                Description,
                PricePerKg,
                DeliveryFee,
                CategoryId
                );

    }
}