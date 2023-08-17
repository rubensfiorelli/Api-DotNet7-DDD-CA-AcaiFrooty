using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Application.Input.InputModels
{
    public class SizePackInputModel
    {
        public float Size { get; set; }

        public SizePack ToEntity()
            => new SizePack(
                Size
                );

    }
}
