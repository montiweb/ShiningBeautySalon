namespace ShiningBeautySalon.Domain.Entities
{
    public class Staff
    {
        public int ID { get; set; }
        public int SalonID { get; set; }
        public int LevelID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
