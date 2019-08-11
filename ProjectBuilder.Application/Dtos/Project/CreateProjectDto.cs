using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBuilder.Application.Dtos.Project
{
    public class CreateProjectDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string InitiatorName { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public IFormFile Files { get; set; }
    }
}
