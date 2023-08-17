using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Application.Output.ViewModels
{
    public class FrootyOrderViewModel
    {
        public FrootyOrderViewModel(Guid id,
            Guid productId,
            string description,
            float weightKg,
            float sizePack,
            int platform,
            int payment,
            Guid storeId,
            DateTime createAt)
        {
            Id = id;
            ProductId = productId;
            Description = description;
            WeightKg = weightKg;
            SizePack = sizePack;
            Platform = platform;
            Payment = payment;
            StoreId = storeId;
            CreateAt = createAt;
        }

        public Guid Id { get; private set; }
        public Guid ProductId { get; private set; }
        public string Description { get; private set; }
        public float WeightKg { get; private set; }
        public float SizePack { get; private set; }
        public int Platform { get; private set; }
        public int Payment { get; private set; }
        public Guid StoreId { get; private set; }
        public DateTime CreateAt { get; private set; }


        public static FrootyOrderViewModel FromEntity(FrootyOrder entity)
        {
            return new FrootyOrderViewModel(
                entity.Id,
                entity.ProductId,
                entity.Description,
                entity.WeightKg,
                entity.SizePack,
                (int)entity.Platform,
                (int)entity.Payment,
                entity.StoreId,
                entity.CreateAt);
        }
    }
}
