using ProjectBuilder.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBuilder.Application.Dtos.Auth
{
    public class LoginOutput
    {
        public string AccessToken { get; set; }

        public ProfileDto Account { get; set; }
    }
}
