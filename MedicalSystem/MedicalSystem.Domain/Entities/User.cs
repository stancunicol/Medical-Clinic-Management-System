namespace MedicalSystem.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public Guid IdRole { get; set; }
        public Role Role { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid IdGender { get; set; }
        public Gender Gender { get; set; }

        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string Telephone { get; set; }

        public string PasswordHash { get; set; }
        public string EmailConfirmationToken { get; set; }
        public DateTime? EmailConfirmationExpiration { get; set; }

        public string PasswordResetToken { get; set; }
        public DateTime? PasswordResetExpiration { get; set; }

        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}