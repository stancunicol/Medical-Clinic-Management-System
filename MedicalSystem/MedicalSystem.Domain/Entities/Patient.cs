namespace MedicalSystem.Domain.Entities
{
    public class Patient
    {
        public Guid Id { get; set; }
        public Guid IdUser { get; set; }
        public User User { get; set; }

        public DateTime Birthdate { get; set; }
        public string BloodType { get; set; }
        public string Conditions { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }

}
