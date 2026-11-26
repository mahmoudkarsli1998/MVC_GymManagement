using MVC_GymManagement.Entities.Enums;

namespace MVC_GymManagement.Entities
{
    public class Trainer:GymUser
    {

        public DateTime HireDate { get; set; }

        public Specialities Specialities { get; set; }

        // Navigation property for the many-to-many relationship with Member
        public ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
