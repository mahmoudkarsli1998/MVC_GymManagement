using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_GymManagement.Entities
{
    public class MemberShip:BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Relationships & navigation properties

        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;

        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "UpComing" :
                                 EndDate > DateTime.Now ? "Active" :
                                 "Expired";
    }
}
