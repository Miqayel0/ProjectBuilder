﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBulder.Infa.Data.Constants
{
    public static class Constants
    {
        public static class Strings
        {
            public static class JwtClaimIdentifiers
            {
                public const string Rol = "rol", Id = "id";
            }

            public static class JwtClaims
            {
                public const string ApiAccess = "api_access";
            }

            public static class SqlDataTypes
            {
                public const string SqlDecimal = "decimal(18,2)";
            }
        }
    }
}
