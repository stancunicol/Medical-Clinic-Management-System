namespace MedicalSystem.Domain.Entities
{
    public class Gender
    {
        public Guid Id { get; set; }
        public string Type { get; set; }

        public ICollection<User> Users { get; set; }
    }
}