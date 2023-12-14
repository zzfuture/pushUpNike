using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class User : BaseEntity
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
    public string RefreshToken { get; set; } = string.Empty;
    public DateTime TokenCreated { get; set; }
    public DateTime TokenExpires { get; set; }
    public string Email { get; set; } = null!;

    public ICollection<Rol> Rols { get; set; } = new HashSet<Rol>();
    public ICollection<UserRol> UserRols { get; set; }
}
