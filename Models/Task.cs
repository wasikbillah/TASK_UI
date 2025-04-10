namespace TASK_UI.Models
{
    public class Task
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int AssignedUserId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime Deadline { get; set; }

        public int StatusId { get; set; }
    }

}
