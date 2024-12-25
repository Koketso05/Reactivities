namespace Domain
{
    public class Learner
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MaidenName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IDNumber { get; set; }
        public string ContactDetails { get; set; }
        public int Grade { get; set; }
        public string Address { get; set; }
        public string DriverID { get; set; }

    }
}