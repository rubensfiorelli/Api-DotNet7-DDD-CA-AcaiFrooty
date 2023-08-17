using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Application.Output.ViewModels
{
    public class StoreViewModel
    {
        public StoreViewModel(Guid id, string title, string city, string state, string location, DateTime createAt)
        {
            Id = id;
            Title = title;
            City = city;
            State = state;
            Location = location;
            CreateAt = createAt;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Location { get; private set; }
        public DateTime CreateAt { get; private set; }


        public static StoreViewModel FromEntity(Store entity)
        {
            return new StoreViewModel(
                entity.Id,
                entity.Title,
                entity.City,
                entity.State,
                entity.Location,
                entity.CreateAt
                );
        }

    }
}
