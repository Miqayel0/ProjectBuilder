using ProjectBuilder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBuilder.Domain.Entities
{
    public class Project : ITrackable
    {
        public Project()
        {
            Donations = new HashSet<Donation>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal? DonatedAmount { get; set; }
        public int DonatedCount { get; set; }
        public string ImageUrl { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Finished { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string InitatorName { get; set; }
        public string InitiatorId { get; set; }
        public User Initiator { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
    }
}
