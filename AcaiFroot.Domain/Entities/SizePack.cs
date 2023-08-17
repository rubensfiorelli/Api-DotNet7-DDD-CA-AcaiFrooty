using AcaiFrooty.Domain.Common;

namespace AcaiFrooty.Domain.Entities
{
    public class SizePack : BaseEntity
    {
        public SizePack(float size) : base()
        {
            Size = size;
        }

        public float Size { get; private set; }

    }
}
