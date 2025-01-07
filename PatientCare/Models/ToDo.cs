namespace PatientCare.Models
{
    public class ToDo : BaseModel
    {
        public int OwnerId { get; set; }
        public int PatientId { get; set; }
        public string? ToDoName { get; set; }
        public string? ToDoDate { get; set; }
        public string? ToDoNote { get; set; }
    }
}
