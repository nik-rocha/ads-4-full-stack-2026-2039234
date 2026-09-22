namespace APIP1.Entities
{
    public class Responsible
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public DateTime BirthDate { get; set; }

        public Responsible(int id, string name, string email, string position, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            Position = position;
            BirthDate = birthDate;
        }
    }
}
