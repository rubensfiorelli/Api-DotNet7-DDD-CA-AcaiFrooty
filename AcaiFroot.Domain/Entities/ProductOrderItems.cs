using AcaiFrooty.Domain.Common;

namespace AcaiFrooty.Domain.Entities
{
    public sealed class ProductOrderItems : BaseEntity
    {
        public ProductOrderItems(string title, double price) : base()
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public double Price { get; private set; }
    }
}
