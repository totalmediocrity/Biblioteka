using System;
using System.Collections.Generic;

namespace BibliotekaFull.models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Cost { get; set; }

    public string Descrip { get; set; } = null!;

    public byte[] Image { get; set; } = null!;

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
}
