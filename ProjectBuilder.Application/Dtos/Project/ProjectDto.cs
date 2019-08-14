using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBuilder.Application.Dtos.Project
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string InitiatorName { get; set; }
        public decimal Amount { get; set; }
        public decimal RisedAmount { get; set; }
        public decimal AmountRisedPercent { get; set; }
        public string Location { get; set; }
        public int SponsorsCount { get; set; }
        public string Status { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
