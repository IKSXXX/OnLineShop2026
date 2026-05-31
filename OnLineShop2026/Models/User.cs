namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string AvatarUrl { get; set; }

        public User(string lastName, string firstName, string email, string avatarUrl)
        {
            Id = Guid.NewGuid();
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            AvatarUrl = avatarUrl;
        }
    }
}
