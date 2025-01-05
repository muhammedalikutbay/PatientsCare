namespace PatientCare.Models
{
    public class Patient : BaseModel
    {
        public int OwnerId { get; set; }
        public string? PatientName { get; set; }
        public string? PatientGender { get; set; }
        public string? RegistrationDate { get; set; }
        public string? BirthDate { get; set; }
        public string? PatientNote { get; set; }
    }
}
