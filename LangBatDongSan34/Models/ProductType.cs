using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class ProductType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal PricePerDay { get; set; }

    public int NumberOfDay { get; set; }

    public decimal Price { get; set; }

    public bool AllowChangeDay { get; set; }

    public int DisplayOrder { get; set; }

    public bool Published { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
