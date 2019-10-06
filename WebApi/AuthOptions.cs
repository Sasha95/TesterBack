using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace WebApi
{
    public class AuthOptions
    {
        public const string ISSUER = "MyAuthSetver";
        public const string AUDIENCE = "https://localhost:44315";
        const string KEY = "ebanina";
        public const int LIFETIME = 1;

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
