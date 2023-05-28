using System;
using System.Collections.Generic;

namespace BibliotekaFull.models;

public partial class Address
{
    public int Id { get; set; }

    public string Address1 { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
