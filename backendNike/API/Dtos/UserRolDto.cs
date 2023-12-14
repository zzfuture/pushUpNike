using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class UserRolDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Rol { get; set; }
    }
}