using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Application.Input.InputModels
{
    public class StoreInputModel
    {
        public string Title { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Location { get; set; }


        public Store ToEntity()
            => new Store(
                Title,
                City,
                State,
                Location);



    }
}
