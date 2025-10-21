namespace MedicalSystem.Domain.Entities
{
    public class Appointment
    {
        public Guid Id { get; set; }

        public Guid IdPatient { get; set; }
        public Patient Patient { get; set; }

        public Guid IdDoctor { get; set; }
        public Doctor Doctor { get; set; }

        public Guid IdService { get; set; }
        public Service Service { get; set; }

        public Guid IdStatus { get; set; }
        public Status Status { get; set; }

        public DateTime Date { get; set; }
        public string Details { get; set; }
        public string FinalNote { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}