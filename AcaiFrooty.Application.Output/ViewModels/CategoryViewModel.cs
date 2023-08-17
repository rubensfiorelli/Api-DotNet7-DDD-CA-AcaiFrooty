using AcaiFrooty.Domain.Entities;

namespace AcaiFrooty.Application.Output.ViewModels
{
    public class CategoryViewModel
    {
        public CategoryViewModel(Guid id, string title, string description, DateTime createAt)
        {
            Id = id;
            Title = title;
            Description = description;
            CreateAt = createAt;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreateAt { get; private set; }

        public static CategoryViewModel FromEntity(Category entity)
        {
            return new CategoryViewModel(
                entity.Id,
                entity.Title,
                entity.Description,
                entity.CreateAt);
        }

    }
}
