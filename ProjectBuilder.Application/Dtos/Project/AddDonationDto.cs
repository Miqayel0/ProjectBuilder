using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBuilder.Application.Dtos.Project
{
    public class CreateDonationDto
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
    }
}
