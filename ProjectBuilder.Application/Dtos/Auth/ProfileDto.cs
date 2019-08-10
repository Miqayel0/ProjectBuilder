using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBuilder.Application.Dtos.Auth
{
    public class ProfileDto
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string IconUrl { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
