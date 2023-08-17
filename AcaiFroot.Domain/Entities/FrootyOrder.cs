using AcaiFrooty.Domain.Common;
using AcaiFrooty.Domain.Enums;

namespace AcaiFrooty.Domain.Entities
{
    public sealed class FrootyOrder : BaseEntity
    {
        public FrootyOrder(Guid productId,
            string description,
            float weightKg,
            float sizePack,
            Eplatform platform,
            Epayment payment,
            Guid storeId) : base()
        {
            ProductId = productId;
            Description = description;
            WeightKg = weightKg;
            SizePack = sizePack;
            Platform = platform;
            Payment = payment;
            StoreId = storeId;
            CreateAt = DateTime.UtcNow;


            Products = new List<ProductOrderItems>();
        }

        public Guid ProductId { get; private set; }
        public Product? Product { get; set; }
        public string Description { get; private set; }
        public float WeightKg { get; private set; }
        public float SizePack { get; private set; }
        public Eplatform Platform { get; private set; }
        public Epayment Payment { get; private set; }
        public Guid StoreId { get; private set; }
        public Store? Store { get; set; }
        public double TotalPrice { get; private set; }
        public List<ProductOrderItems> Products { get; private set; }


        public void SetupOrder(List<Product> products)
        {
            foreach (var item in products)
            {
                var productPrice = item.PricePerKg + item.DeliveryFee * WeightKg;

                TotalPrice += productPrice;
                Products.Add(new ProductOrderItems(item.Title, productPrice));

            }
        }
    }
}
