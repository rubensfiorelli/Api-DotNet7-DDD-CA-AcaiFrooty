using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Application.Input.InputModels
{
    public class CategoryInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Category ToEntity()
            => new Category(

                Title,
                Description
            );

    }
}
