using System.ComponentModel.DataAnnotations;

namespace AcaiFrooty.Domain.Common
{
    public abstract class BaseEntity
    {
        //private List<Notification>? _notifications;

        [Key]
        public Guid Id { get; protected set; }
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        private DateTime _createAt;

        public DateTime CreateAt
        {
            get { return _createAt; }
            set => _createAt = DateTime.UtcNow;
        }

        //public abstract bool Validate();


        //[NotMapped]
        //public IReadOnlyCollection<Notification>? Notifications => _notifications;

        //protected void SetNotifications(List<Notification> notifications)
        //{
        //    _notifications = notifications;
        //}
    }
}
