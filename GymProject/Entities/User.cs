namespace GymProject.Entities
{
    public class User
    {
        public string NumberId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; } = null;
        public string? phoneNumber { get; set; }
        public DateTime entryDate { get; set; }

    }
}
