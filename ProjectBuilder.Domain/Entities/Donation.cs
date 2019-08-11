namespace ProjectBuilder.Domain.Entities
{
    public class Donation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public decimal? CurrentDonation { get; set; }
    }
}
