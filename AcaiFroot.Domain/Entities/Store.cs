using AcaiFrooty.Domain.Common;

namespace AcaiFrooty.Domain.Entities
{
    public class Store : BaseEntity
    {
        public Store(string title, string city, string state, string location) : base()
        {
            Title = title;
            City = city;
            State = state;
            Location = location;
        }

        public string Title { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Location { get; private set; }
    }
}
