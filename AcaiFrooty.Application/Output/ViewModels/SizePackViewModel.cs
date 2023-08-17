using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Application.Output.ViewModels
{
    public class SizePackViewModel
    {
        public SizePackViewModel(float size)
        {
            Size = size;
        }

        public float Size { get; private set; }


        public static SizePackViewModel FromEntity(SizePack entity)
        {
            return new SizePackViewModel(
                entity.Size);
        }
    }
}
