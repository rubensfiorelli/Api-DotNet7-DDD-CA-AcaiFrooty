using AcaiFrooty.Domain.Entities;
using AcaiFrooty.Domain.Enums;

namespace AcaiFrooty.Application.Input.InputModels
{
    public class AddFrootyOrderInputModel
    {
        public Guid ProductId { get; set; }
        public string Description { get; set; }
        public float WeightKg { get; set; }
        public float SizePack { get; set; }
        public Eplatform Platform { get; set; }
        public Epayment Payment { get; set; }
        public Guid StoreId { get; set; }
        public List<ProductInputModel> Products { get; set; }

        public FrootyOrder ToEntity()
            => new FrootyOrder(
                ProductId,
                Description,
                WeightKg,
                SizePack,
                Platform,
                Payment,
                StoreId);

    }
}
