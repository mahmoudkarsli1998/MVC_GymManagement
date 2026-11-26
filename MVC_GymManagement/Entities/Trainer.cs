using MVC_GymManagement.Entities.Enums;

namespace MVC_GymManagement.Entities
{
    public class Trainer:GymUser
    {
        // HireDate is stored in BaseEntity.CreatedAt (mapped to the "HireDate" column)

        public Specialities Specialities { get; set; }

        // Navigation property for the many-to-many relationship with Member
        public ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
