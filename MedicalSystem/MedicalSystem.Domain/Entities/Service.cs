namespace MedicalSystem.Domain.Entities
{
    public class Service
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}