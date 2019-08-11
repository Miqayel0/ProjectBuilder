using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBuilder.Domain.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            Donations = new HashSet<Donation>();
            InitialProjects = new HashSet<Project>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IconUrl { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
        public virtual ICollection<Project> InitialProjects { get; set; }
    }
}
