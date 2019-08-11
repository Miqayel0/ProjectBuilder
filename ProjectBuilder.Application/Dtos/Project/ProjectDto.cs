﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBuilder.Application.Dtos.Project
{
    public class ProjectDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string InitiatorName { get; set; }
        public decimal Amount { get; set; }
        public decimal DonationsCount { get; set; }
        public int AmountRisedPercent { get; set; }
        public string Location { get; set; }
        public int SponsorsCount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
