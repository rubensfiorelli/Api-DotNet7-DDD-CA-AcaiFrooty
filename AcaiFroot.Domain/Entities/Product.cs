using AcaiFrooty.Domain.Common;

namespace AcaiFrooty.Domain.Entities
{
    public sealed class Product : BaseEntity
    {
        public Product(string title, string description, double pricePerKg, double deliveryFee, Guid categoryId) : base()
        {
            Title = title;
            Description = description;
            PricePerKg = pricePerKg;
            DeliveryFee = deliveryFee;
            CategoryId = categoryId;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public double PricePerKg { get; private set; }
        public double DeliveryFee { get; private set; }
        public Guid CategoryId { get; private set; }
        public Category? Category { get; private set; }

    }
}
