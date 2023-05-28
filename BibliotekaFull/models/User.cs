using System;
using System.Collections.Generic;

namespace BibliotekaFull.models;

public partial class User
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public int Password { get; set; }

    public int RoleId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Role Role { get; set; } = null!;
}
