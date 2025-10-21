namespace MedicalSystem.Domain.Entities
{
    public class Status
    {
        public Guid Id { get; set; }
        public string Type { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}