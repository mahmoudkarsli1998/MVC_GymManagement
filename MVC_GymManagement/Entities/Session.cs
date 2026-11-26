namespace MVC_GymManagement.Entities
{
    public class Session : BaseEntity
    {

        public string Description { get; set; } = default!;
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation properties Relationships
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; } = default!;

    }
}
