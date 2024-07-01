namespace BiniWeb.Models
{
    public class Member
    {
        public long Id { get; set; }
        public required string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public DateTime? BirthDate {get; set;}
        public int? Age {get; set;}
        public string? Position {get; set;}
        public byte[]? ProfileImage {get; set;}

    }
}