namespace MedicalSystem.Domain.Entities
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public Guid IdUser { get; set; }
        public User User { get; set; }

        public string Specialization { get; set; }
        public int Experience { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }

}
