using MVC_GymManagement.Entities.Enums;

namespace MVC_GymManagement.Entities
{
    public class Member:GymUser
    {


        public string? Photo { get; set; }

        // RelationShip Many to Many with MemberShip
        public ICollection<MemberShip> MemberSubscriptions { get; set; } = new List<MemberShip>();

        // Relationship with Plan 
        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;
    }
}
