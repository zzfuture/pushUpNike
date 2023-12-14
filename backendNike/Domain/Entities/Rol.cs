using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Rol : BaseEntity
{
        public string Name { get; set; }
        public ICollection<User> Users { get; set; } = new HashSet<User>();
        public ICollection<UserRol> UserRols { get; set; }
}
